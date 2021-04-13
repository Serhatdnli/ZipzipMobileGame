using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class MenuYonetimi : MonoBehaviour
{

    public GameObject MenuEkrani, MagazaEkrani,AyarlarEkrani,SesAcik,SesKapali,SesAcik2,SesKapali2,SesAcik3,SesKapali3,Karakter1,Karakter1Secili,Karakter2Kilitli,Karakter2,Karakter2Secili,Karakter3,Karakter3Secili,Karakter3Kilitli,Karakter4Kilitli,Karakter4,Karakter4Secili,KilitAcmaEkrani,AltinYokEkrani,Credits;
    public AudioSource menuses,butonses;
    bool MagazaAcikmi = false;
    
    
    void Start()
    {
        if(VeriYonetimi.kayit.menuses == 0)
        {
            menuses.mute = false;
        }
        else
        {
            menuses.mute = true;
        }        

    }
    void Update() {
        GameObject.Find("MenuAltin").GetComponent<Text>().text = VeriYonetimi.kayit.toplamAltin.ToString();
        MenuYukle();
        KarakterSecimi();
                
    }

    public void MagazaAc()
    {
        MenuEkrani.SetActive(false);
        MagazaEkrani.SetActive(true);
        MagazaAcikmi = true;
        if(VeriYonetimi.kayit.efektses == 0)
        {
            butonses.Play();
        }
        
    }
        public void MagazaKapat()
    {
        MagazaAcikmi = false;
        MenuEkrani.SetActive(true);
        MagazaEkrani.SetActive(false);
        VeriYonetimi.kayit.Kaydet();
        
        if(VeriYonetimi.kayit.efektses == 0)
        {
            butonses.Play();
        }
        
    }
    


    public void OynaButon()
    {
        VeriYonetimi.kayit.OyunDurmusmu = false;
        SceneManager.LoadScene(1);
        if(VeriYonetimi.kayit.efektses == 0)
        {
            butonses.Play();
        }
    }



    public void AyarKapat()
    {
        VeriYonetimi.kayit.Kaydet();
        MenuEkrani.SetActive(true);
        AyarlarEkrani.SetActive(false);
        if(VeriYonetimi.kayit.efektses == 0)
        {
            butonses.Play();
        }
        

    }


    public void AyarAc()
    {
        MenuEkrani.SetActive(false);
        AyarlarEkrani.SetActive(true);
        AyarKontrol();
        if(VeriYonetimi.kayit.efektses == 0)
        {
            butonses.Play();
        }
        
        
    }

    public void SesAc()
    {
        SesKapali.SetActive(true);
        SesAcik.SetActive(false);
        GameObject.Find("MuzikBilgi").GetComponent<Text>().text = "menu music is off";
        menuses.mute = true;
        VeriYonetimi.kayit.menuses = 1;
    }

    public void SesKapat()
    {
        SesKapali.SetActive(false);
        SesAcik.SetActive(true);
        GameObject.Find("MuzikBilgi").GetComponent<Text>().text = "menu music is on";
        menuses.mute = false;
        VeriYonetimi.kayit.menuses = 0;
    }

    public void OyunIciSesKapat()
    {
        SesKapali2.SetActive(false);
        SesAcik2.SetActive(true);
        GameObject.Find("SesBilgi").GetComponent<Text>().text = "ın game sounds is on";
        VeriYonetimi.kayit.oyunicises = 0;
    } 
    public void OyunIciSesAc()
    {
        SesKapali2.SetActive(true);
        SesAcik2.SetActive(false);
        GameObject.Find("SesBilgi").GetComponent<Text>().text = "ın game sounds is off";
        VeriYonetimi.kayit.oyunicises = 1;
    } 

        public void EfektKapat()
    {
        SesKapali3.SetActive(false);
        SesAcik3.SetActive(true);
        GameObject.Find("EfektBilgi").GetComponent<Text>().text = "effect sounds is on";
        VeriYonetimi.kayit.efektses = 0;
    } 
    public void EfektAc()
    {
        SesKapali3.SetActive(true);
        SesAcik3.SetActive(false);
        GameObject.Find("EfektBilgi").GetComponent<Text>().text = "effect sounds is off";
        VeriYonetimi.kayit.efektses = 1;
    }  

    void AyarKontrol()
    {
        if(VeriYonetimi.kayit.efektses == 0)
        {
            EfektKapat();
        }
        else
        {
            EfektAc();
        }
        if(VeriYonetimi.kayit.oyunicises == 0)
        {
            OyunIciSesKapat();
        }
        else
        {
            OyunIciSesAc();
        }
        if(VeriYonetimi.kayit.menuses == 0)
        {
            SesKapat();
        }
        else
        {
            SesAc();
        }
    }


    void KarakterSecimi()
    { 
        if(MagazaAcikmi)
        {

            if(VeriYonetimi.kayit.secilenKarakter == 0)
            {
                Karakter1Secili.SetActive(true);
                Karakter1.SetActive(false);              
            }
            else
            {
                Karakter1Secili.SetActive(false);   
                Karakter1.SetActive(true);  

            }


            if(VeriYonetimi.kayit.secilenKarakter == 1 && VeriYonetimi.kayit.karakter2kilit == 1)
            {
                Karakter2Secili.SetActive(true);
                Karakter2.SetActive(false);              
            }
            else if(VeriYonetimi.kayit.karakter2kilit == 1)
            {
                Karakter2Secili.SetActive(false);   
                Karakter2.SetActive(true);  

            }


            if(VeriYonetimi.kayit.secilenKarakter == 2 && VeriYonetimi.kayit.karakter3kilit == 1)
            {
                Karakter3Secili.SetActive(true);
                Karakter3.SetActive(false);              
            }
            else if(VeriYonetimi.kayit.karakter3kilit == 1)
            {
                Karakter3Secili.SetActive(false);   
                Karakter3.SetActive(true);  

            }

            if(VeriYonetimi.kayit.secilenKarakter == 3 && VeriYonetimi.kayit.karakter4kilit == 1)
            {
                Karakter4Secili.SetActive(true);
                Karakter4.SetActive(false);              
            }
            else if(VeriYonetimi.kayit.karakter3kilit == 1)
            {
                Karakter4Secili.SetActive(false);   
                Karakter4.SetActive(true);  

            }


            
        }    
    }

    public void MenuYukle()
    {
        if(MagazaAcikmi)
        {

            if(VeriYonetimi.kayit.karakter2kilit == 1)
            {
                Karakter2Kilitli.SetActive(false);
                Karakter2.SetActive(true);
            }else 
            {
                Karakter2Kilitli.SetActive(true);
                Karakter2.SetActive(false);

            }
            if(VeriYonetimi.kayit.karakter3kilit == 1)
            {
                Karakter3Kilitli.SetActive(false);
                Karakter3.SetActive(true);
            }else 
            {
                Karakter3Kilitli.SetActive(true);
                Karakter3.SetActive(false);

            }
            if(VeriYonetimi.kayit.karakter4kilit == 1)
            {
                Karakter4Kilitli.SetActive(false);
                Karakter4.SetActive(true);
            }else 
            {
                Karakter4Kilitli.SetActive(true);
                Karakter4.SetActive(false);

            }

        }
    }
   public void Karakter1Sec()
    {
        VeriYonetimi.kayit.secilenKarakter = 0;
    }
    public void Karakter2Sec()
    {
        VeriYonetimi.kayit.secilenKarakter = 1;
    }
    public void Karakter3Sec()
    {
        VeriYonetimi.kayit.secilenKarakter = 2;
    }
    public void Karakter4Sec()
    {
        VeriYonetimi.kayit.secilenKarakter = 3;
    }

    public void Karakter2Kilitac()
    {
        KilitAcmaEkrani.SetActive(true);
        PlayerPrefs.SetInt("karakter",1);

    }
        public void Karakter3Kilitac()
    {
        KilitAcmaEkrani.SetActive(true);
        PlayerPrefs.SetInt("karakter",2);
    }
        public void Karakter4Kilitac()
    {
        KilitAcmaEkrani.SetActive(true);
        PlayerPrefs.SetInt("karakter",3);
    }

    public void Evet()
    {        
        KilitAc();
    }
    public void Hayir()
    {
        KilitAcmaEkrani.SetActive(false);        
    }

    


    public void KilitAc()
    {
        
        if(PlayerPrefs.GetInt("karakter")== 1 && VeriYonetimi.kayit.toplamAltin > 2000)
        {
            VeriYonetimi.kayit.karakter2kilit = 1;
            VeriYonetimi.kayit.toplamAltin -= 2000;
            VeriYonetimi.kayit.Kaydet();
            Karakter2Kilitli.SetActive(false);            
            KilitAcmaEkrani.SetActive(false);
            Karakter2.SetActive(true);

        }
        else if(PlayerPrefs.GetInt("karakter")==2 && VeriYonetimi.kayit.toplamAltin > 6000)
        {
            VeriYonetimi.kayit.karakter3kilit = 1;
            VeriYonetimi.kayit.toplamAltin -= 6000;
            VeriYonetimi.kayit.Kaydet();
            KilitAcmaEkrani.SetActive(false);
            Karakter3Kilitli.SetActive(false);
            Karakter3.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("karakter")==3 && VeriYonetimi.kayit.toplamAltin > 10000)
        {
            VeriYonetimi.kayit.karakter4kilit = 1;
            VeriYonetimi.kayit.toplamAltin -= 10000;
            VeriYonetimi.kayit.Kaydet();
            KilitAcmaEkrani.SetActive(false);
            Karakter4Kilitli.SetActive(false);
            Karakter4.SetActive(true);

        }
        else
        {
            AltinYokEkrani.SetActive(true);
        }

    }

    public void AltinyokEkraniKapa()
    {
        KilitAcmaEkrani.SetActive(false);
        AltinYokEkrani.SetActive(false);
    }

    
    

    public void CreditsButon()
    {
        Credits.SetActive(true);
    }
    public void CreditsKapatButon()
    {
        Credits.SetActive(false);
    }

    public void Cıkıs()
    {
        Application.Quit();
    }




       
}
