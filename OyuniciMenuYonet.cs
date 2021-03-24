using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class OyuniciMenuYonet : MonoBehaviour
{
    public PlayerController OlumKontroller;

    

    public GameObject DurdurmaEkrani, Oyunekrani,OlumEkrani,Karakter1,Karakter2,Karakter3,Karakter4,LoadingEkrani;
    public AudioSource butonses,butonses2,durdurmases;
    
    

    void Start() {
        Destroy(LoadingEkrani,0.7f);

        
        
        if(VeriYonetimi.kayit.secilenKarakter == 0)
        {
            Karakter1.SetActive(true);
            /*Destroy(Karakter2);
            Destroy(Karakter3);
            Destroy(Karakter4);
            Karakter2.SetActive(false);
            Karakter3.SetActive(false);
            Karakter4.SetActive(false);*/
            //Karakter5.SetActive(false);
        }    
        else if(VeriYonetimi.kayit.secilenKarakter == 1)
        {
            Karakter2.SetActive(true);
            /*Destroy(Karakter1);
            Destroy(Karakter3);
            Destroy(Karakter4);
            Karakter1.SetActive(false);
            
            Karakter3.SetActive(false);
            Karakter4.SetActive(false);*/
            //Karakter5.SetActive(false);
        }
        else if(VeriYonetimi.kayit.secilenKarakter == 2)
        {
            Karakter3.SetActive(true);
            /*Destroy(Karakter2);
            Destroy(Karakter1);
            Destroy(Karakter4);
            Karakter1.SetActive(false);
            Karakter2.SetActive(false);
            
            Karakter4.SetActive(false);*/
            //Karakter5.SetActive(false);
        }
        else if(VeriYonetimi.kayit.secilenKarakter == 3)
        {
           /* Karakter1.SetActive(false);
            Karakter2.SetActive(false);
            Karakter3.SetActive(false);*/
            Karakter4.SetActive(true);
            /*Destroy(Karakter2);
            Destroy(Karakter3);
            Destroy(Karakter1);
            Karakter5.SetActive(false);*/
        }
        /*else if(VeriYonetimi.kayit.secilenKarakter == 4)
        {
            Karakter1.SetActive(false);
            Karakter2.SetActive(false);
            Karakter3.SetActive(false);
            Karakter4.SetActive(false);
            Karakter5.SetActive(true);
        }*/
        
        
        
    }

    public void OyunuDurdur()
    {
        VeriYonetimi.kayit.OyunDurmusmu = true;
        Time.timeScale = 0;
        Oyunekrani.SetActive(false);
        DurdurmaEkrani.SetActive(true);
        if(VeriYonetimi.kayit.efektses == 0)
        {
            butonses2.Play();
        }
    }

    public void DevamButon()
    {
        VeriYonetimi.kayit.OyunDurmusmu = false;
        Time.timeScale = 0.9f;
        Oyunekrani.SetActive(true);
        DurdurmaEkrani.SetActive(false);
        if(VeriYonetimi.kayit.efektses == 0)
        {
            durdurmases.Stop();
            butonses2.Play();
        }
    }

    public void YenidenOynaButon()
    {   
        VeriYonetimi.kayit.reklamSayac += 1;
        if(VeriYonetimi.kayit.efektses == 0)
        {
            durdurmases.Stop();
            butonses2.Play();
        }
        PlayerPrefs.SetInt("ReklamDurumu",1);
        VeriYonetimi.kayit.Kaydet();
        Time.timeScale = 0.9f;
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(1);
        VeriYonetimi.kayit.OyunDurmusmu = true;
        VeriYonetimi.kayit.kombo = 0;
        if(VeriYonetimi.kayit.efektses == 0)
        {
            durdurmases.Stop();
            butonses.Play();
        }
    }
    public void MenuyeDonButon()
    {
        
        VeriYonetimi.kayit.Kaydet();
        VeriYonetimi.kayit.OyunDurmusmu = true;
        VeriYonetimi.kayit.kombo = 0;
        Time.timeScale = 0.9f;
        SceneManager.LoadScene(0);
        if(VeriYonetimi.kayit.efektses == 0)
        {
            durdurmases.Stop();
            butonses.Play();
        }   
    }
    


    

    



}
