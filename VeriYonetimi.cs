using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;

public class VeriYonetimi : MonoBehaviour
{

    public static VeriYonetimi kayit;   
    private int ToplamAltin = 0;
    private int AnlikAltin = 0;
    public int Rekor = 0,RekorKombo;
    private int anlikPuan = 0;
    private int Kombo;
    public bool OyunDurmusmu = false;
    private int Oyunicises,Menuses,Efektses,SecilenKarakter = 0,Karakter2kilit = 0,Karakter3kilit = 0,Karakter4kilit = 0, ReklamSayac = 1;
    EasyFileSave myDosya;
    

    void Awake() {

        if (kayit == null)
        {
            kayit = this;
            BaslangictaCalistir();
            
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        
    }
    
        

    void Update()
    {
        RekorKaydet();        
    }

    public int reklamSayac
    {
        get
        {
            return ReklamSayac;
        }
        set
        {
            ReklamSayac = value;
        }
    }

    public int toplamAltin
    {
        get
        {
            return ToplamAltin;
        }
        set
        {
            ToplamAltin = value;
            
        }
    }

    public int AnlikPuan
    {
        get
        {
            return anlikPuan;
        }
        set
        {
            anlikPuan = value;
            if(!OyunDurmusmu)
            {
                GameObject.Find("Puan").GetComponent<Text>().text = anlikPuan.ToString();
            }
            
            
        }
    }

    public int kombo
    {
        get
        {
            return Kombo;
        }
        set
        {
            Kombo = value;
            if(!OyunDurmusmu)
            {
                GameObject.Find("KomboSayaci").GetComponent<Text>().text = Kombo.ToString();
            }
            
        }
    }


    public int anlikAltin
    {
        get
        {
            return AnlikAltin;
        }
        set
        {
            AnlikAltin = value;
            if(!OyunDurmusmu)
            {
                GameObject.Find("Altin").GetComponent<Text>().text = AnlikAltin.ToString();                
            }

        }
    }
        public int oyunicises
    {
        get
        {
            return Oyunicises;
        }
        set
        {
            Oyunicises = value;
            
        }
    }

    public int menuses
    {
        get
        {
            return Menuses;
        }
        set
        {
            Menuses = value;
            
        }
    }

    public int efektses
    {
        get
        {
            return Efektses;
        }
        set
        {
            Efektses = value;
            
        }
    }

    public int secilenKarakter
    {
        get
        {
            return SecilenKarakter;
        }
        set
        {
            SecilenKarakter = value;
        }
    }

    public int karakter2kilit
    {
        get
        {
            return Karakter2kilit;
        }
        set
        {
            Karakter2kilit = value;
        }
    }
    public int karakter3kilit
    {
        get
        {
            return Karakter3kilit;
        }
        set
        {
            Karakter3kilit = value;
        }
    }
    public int karakter4kilit
    {
        get
        {
            return Karakter4kilit;
        }
        set
        {
            Karakter4kilit = value;
        }
    }

    public void RekorKaydet()
    {
        if (AnlikPuan > Rekor)
        {
            Rekor = AnlikPuan;
        }
        if(RekorKombo < kombo)
        {
            RekorKombo = kombo;
        }
    }

    void BaslangictaCalistir()
    {
        myDosya = new EasyFileSave();
        Yukle();

    }

    public void Kaydet()
    {
        toplamAltin += anlikAltin;
        myDosya.Add("Rekor",Rekor);
        myDosya.Add("RekorKombo",RekorKombo);
        myDosya.Add("ToplamAltin",toplamAltin);
        myDosya.Add("Menuses",Menuses);
        myDosya.Add("Oyunicises",Oyunicises);
        myDosya.Add("Efektses",Efektses);
        myDosya.Add("SecilenKarakter",SecilenKarakter);
        myDosya.Add("Karakter2kilit",Karakter2kilit);
        myDosya.Add("Karakter3kilit",Karakter3kilit);
        myDosya.Add("Karakter4kilit",Karakter4kilit);
        myDosya.Save();
        
    }


    public void Yukle()
    {
        if (myDosya.Load())
        {
            toplamAltin = myDosya.GetInt("ToplamAltin");
            Rekor = myDosya.GetInt("Rekor");
            RekorKombo = myDosya.GetInt("RekorKombo");
            Menuses = myDosya.GetInt("Menuses");
            Oyunicises = myDosya.GetInt("Oyunicises");
            Efektses = myDosya.GetInt("Efektses");
            SecilenKarakter = myDosya.GetInt("SecilenKarakter");
            Karakter2kilit = myDosya.GetInt("Karakter2kilit");
            Karakter3kilit = myDosya.GetInt("Karakter3kilit");
            Karakter4kilit = myDosya.GetInt("Karakter4kilit");
        }
    }


}
