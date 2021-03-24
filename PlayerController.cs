using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
//using GoogleMobileAds.Api;



public class PlayerController : MonoBehaviour
{
    public Rigidbody2D karakter;
    Animator karakterAnimator;
    public float hiz,ziplamasiddeti,ziplamasikligi,sonrakiziplamazamani,yercap;
    public bool yon = true,yerdemi = false,OyuncuDead = false;
    public Transform yerkontrolpozisyon,yerkontrolpozisyon2,KomboEfekt,KomboEfekt2,KomboEfekt3,KomboEfekt4;
    public LayerMask yerkontrollayer;
    public Text Puan,Altin,HataSayaci;
    public int AltinTutucu,c=0,MaksimumKombo=0,HataSayacii,b = 0;
    public GameObject OlumEkrani,Oyunekrani,acemi,tecrubeli,uzman,inanilmaz;
    float tutucu,OncekiKonum,SonrakiKonum;
    int sayac,sayac2,sayac3,sayac5,sayac6;
    public AudioSource oyunicises,ziplamases2,ziplamases3,Hatasesi,Olumsesi1,Olumsesi2,Olumsesi3,Olumsesi4,Olumsesi5,KomboSes3,KomboSes4,Kombofses1,Kombofses2;
    private AudioSource ziplamases;


    void Start()
    {     
        SesDurumu();  
        VeriYonetimi.kayit.OyunDurmusmu = false;
        OyuncuDead = false;
        karakter = GetComponent<Rigidbody2D>();
        karakterAnimator = GetComponent<Animator>();        
        ziplamases = GetComponent<AudioSource>();
        Time.timeScale = 0.9f;                
    }
    void Update()
    {  
        HataKontrol();
        ZemindemiKontrol();
        Zipla();  
        OlumKontrol();
        YatayHareket();                
    }


    void SesDurumu()
    {
        if(VeriYonetimi.kayit.oyunicises==1)
        {
            oyunicises.mute = true;
        }
        else 
        {
            oyunicises.mute = false;
        }
    }

    void YatayHareket()
    {
        
        karakter.velocity = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal") * hiz,karakter.velocity.y);
        karakterAnimator.SetFloat("KarakterHiz",Mathf.Abs(CrossPlatformInputManager.GetAxis("Horizontal")));
        
        if (karakter.velocity.x < 0 && yon)
        {
            
            YonDegis();
        }
        else if (karakter.velocity.x > 0 && !yon)
        {
            
            YonDegis();
        }
        
    }

    void YonDegis()
    {
        yon = !yon;
        Vector3 yononbellek = transform.localScale;
        yononbellek.x *= -1;
        transform.localScale = yononbellek;
    }
    
    public void Zipla()
    {
        
        
        KomboKontrol();
       
        
        if (CrossPlatformInputManager.GetButtonDown("Jump") && yerdemi && sonrakiziplamazamani < Time.timeSinceLevelLoad)
        {   
            ZiplamaSesi();
            sayac = 1;
            sonrakiziplamazamani = Time.timeSinceLevelLoad + ziplamasikligi;
            karakter.AddForce(new Vector2(0f,ziplamasiddeti));
            tutucu = tutucu + 3.4f;
            sayac2 = 1; 
            sayac3 = 1; 
            
                                    
        }
          
        
        
        if(karakter.position.y > 0 && !OyuncuDead)
            {
                int a= (int) karakter.position.y;
                if (a > c)
                {
                    c=a;
                }
                
                VeriYonetimi.kayit.AnlikPuan = c;
                b = (c / 10) + MaksimumKombo ;
                VeriYonetimi.kayit.anlikAltin = b;
            }
        


    }
    void ZemindemiKontrol()
    {
        if(Physics2D.OverlapCircle(yerkontrolpozisyon.position,yercap,yerkontrollayer) || Physics2D.OverlapCircle(yerkontrolpozisyon2.position,yercap,yerkontrollayer))
        {
            yerdemi = true;
            
        }
        else
        {
            yerdemi = false;
            
        }
        
        karakterAnimator.SetBool("Yerdemi",yerdemi);
    }
    
    void KomboKontrol()
    {

        

        if(VeriYonetimi.kayit.kombo > 4 && VeriYonetimi.kayit.kombo <= 14 && CrossPlatformInputManager.GetButtonDown("Jump"))
        {
           Instantiate(KomboEfekt,new Vector2(karakter.position.x,(karakter.position.y+3f)),Quaternion.identity);
           karakterAnimator.SetBool("Kombo",true);
           sayac6 = 1;
           

        }
        if(VeriYonetimi.kayit.kombo > 14 && VeriYonetimi.kayit.kombo <= 24 && CrossPlatformInputManager.GetButtonDown("Jump"))
        {
           Instantiate(KomboEfekt2,new Vector2(karakter.position.x,(karakter.position.y+3f)),Quaternion.identity);
           karakterAnimator.SetBool("Kombo",true);
           sayac6 = 2;
           
           
        }        
        if(VeriYonetimi.kayit.kombo > 24 && VeriYonetimi.kayit.kombo <= 34 && CrossPlatformInputManager.GetButtonDown("Jump"))
        {
           
           sayac6 = 3;
           Instantiate(KomboEfekt3,new Vector2(karakter.position.x,(karakter.position.y+3f)),Quaternion.identity);
           karakterAnimator.SetBool("Kombo",true);
           
        }
        if(VeriYonetimi.kayit.kombo > 34 && CrossPlatformInputManager.GetButtonDown("Jump"))
         {
            
           sayac6 = 4; 
           Instantiate(KomboEfekt4,new Vector2(karakter.position.x,(karakter.position.y+3f)),Quaternion.identity);
           karakterAnimator.SetBool("Kombo",true);
           
        }

           
    }

    void HataKontrol()
    {
        
        if(yerdemi && !CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            
            if(sayac == 1)
            {
                OncekiKonum = SonrakiKonum;
                SonrakiKonum = karakter.position.y; 
                sayac = 2;
            }
            else
            {
                SonrakiKonum = karakter.position.y;                
            }
            

            if(OncekiKonum >= SonrakiKonum && sayac3 == 1)
            {   
                HataSayacii = (int)((SonrakiKonum-tutucu)/3.6f)+4;
                HataSayaci.text = HataSayacii.ToString(); 
                karakterAnimator.SetBool("Kombo",false);               
                
                if(!OyuncuDead)
                {   
                    if(VeriYonetimi.kayit.efektses == 0)
                    {
                        Hatasesi.Play();
                    }
                    KomboGoster();
                    karakterAnimator.SetBool("Dusme",true);                 
                    VeriYonetimi.kayit.kombo = 0;
                    sayac3 = 2;
                    sayac6 = 0;
                }        

            }
            else if(sayac2 == 1)
                {
                    HataSayacii = (int)((SonrakiKonum-tutucu)/3.6f)+4;
                    HataSayaci.text = HataSayacii.ToString(); 
                    karakterAnimator.SetBool("Dusme",false); 
                    if(VeriYonetimi.kayit.kombo == 3)
                    {
                        KomboGoster();
                    } 
                    if(!OyuncuDead)
                    {   
                        
                        VeriYonetimi.kayit.kombo++;
                        sayac2 = 2;
                        if(MaksimumKombo < VeriYonetimi.kayit.kombo)
                        {
                            MaksimumKombo = VeriYonetimi.kayit.kombo;
                        }
                    }

                }



            sayac = 2; 
        }
        
        
        
        
    }
    void OlumKontrol()
    {
        if((tutucu-17f) > karakter.position.y)
        {  
                oyunicises.Stop();
                
            /*if(VeriYonetimi.kayit.efektses == 0)
            {                
                Olumsesi4.Play();
            }*/
        VeriYonetimi.kayit.OyunDurmusmu = true;
        Time.timeScale = 0;
        OlumEkrani.SetActive(true);
        GameObject.Find("OlumRekorSayaci").GetComponent<Text>().text = VeriYonetimi.kayit.Rekor.ToString();
        GameObject.Find("OlumSkorSayaci").GetComponent<Text>().text = c.ToString();
        GameObject.Find("KomboRekorSayaci").GetComponent<Text>().text = VeriYonetimi.kayit.RekorKombo.ToString();
        GameObject.Find("KomboSkorSayaci").GetComponent<Text>().text = MaksimumKombo.ToString();
        Oyunekrani.SetActive(false);

        if(PlayerPrefs.GetInt("ReklamDurumu") == 0)
        {
            
            tutucu -= 17f;
            Oyunekrani.SetActive(true);
            VeriYonetimi.kayit.OyunDurmusmu = false;
            Time.timeScale = 0.9f;            
            OlumEkrani.SetActive(false);
            PlayerPrefs.SetInt("ReklamDurumu",1);
            OyuncuDead = false;     
            
        
        }
        else
        {
            OyuncuDead = true;
            
        }
                
        }
        
    }

    void ZiplamaSesi()
    {
        if(VeriYonetimi.kayit.efektses == 0)
        {
            if((VeriYonetimi.kayit.kombo % 2) ==0)
            {
                ziplamases2.Play();
            }
            else if((VeriYonetimi.kayit.kombo % 3) ==0)
            {
                ziplamases3.Play();
            }
            else if(VeriYonetimi.kayit.kombo != 0)
            {
                ziplamases.Play();
            }

                
        }

    }

    void KomboGoster()
    {
            if(sayac6 == 1)
            {
                acemi.SetActive(true);
                
                if(VeriYonetimi.kayit.efektses == 0)
                {
                    Kombofses1.Play();               
                }
            }
            else if(sayac6 == 2)
            {
                tecrubeli.SetActive(true);
                
                if(VeriYonetimi.kayit.efektses == 0)
                {
                    Kombofses2.Play();              
                }
            }
            else if(sayac6 == 3)
            {
                uzman.SetActive(true);
               
                if(VeriYonetimi.kayit.efektses == 0)
                {
                    KomboSes3.Play();               
                }
            }
            else if(sayac6 == 4 )
            {
                inanilmaz.SetActive(true);
               
                if(VeriYonetimi.kayit.efektses == 0)
                {
                    KomboSes4.Play();               
                }
            }
            else
            {   
                
                inanilmaz.SetActive(false);
                uzman.SetActive(false);
                tecrubeli.SetActive(false);
                acemi.SetActive(false);

            }

    }



    
}
