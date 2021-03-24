using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZeminOlusturma : MonoBehaviour
{

    public PlayerController OlumKontrol;
    public Rigidbody2D Player,Karakter1,Karakter2,Karakter3,Karakter4;
    float width,KonumTutucu,Konum;
    float i=-1.4f;
    public GameObject Zemin1,Zemin2,Zemin3,Zemin4,Zemin5,Zemin0,Zemin,Zemin6,Zemin7,Zemin8,Zemin9,Zemin10,Zemin11,Zemin12,Zemin13;
    
    void Start() 
    {
        if(VeriYonetimi.kayit.secilenKarakter == 0)
        {
            Player = Karakter1;
            
        }    
        else if(VeriYonetimi.kayit.secilenKarakter == 1)
        {
            Player = Karakter2;
        }
        else if(VeriYonetimi.kayit.secilenKarakter == 2)
        {
            Player = Karakter3;
        }
        else if(VeriYonetimi.kayit.secilenKarakter == 3)
        {
            Player = Karakter4;
        }
        /*else if(VeriYonetimi.kayit.secilenKarakter == 4)
        {
            Player = Karakter5;
        }*/
        StartCoroutine(ZeminOlustur());
    }

    public IEnumerator ZeminOlustur()
    {
        while (!OlumKontrol.OyuncuDead)
        {
            if(Player.position.y + 20 > i){
                if(i < 100)
                {
                    KonumTutucu = Konum; 
                    Konum = Random.Range(-4.8f,4.8f);
                    if((int)KonumTutucu == (int)Konum)
                    {
                        Konum += Random.Range(2.5f,4f); 
                    }                    
                    i += 3.6f;                    
                    Instantiate(Zemin0,new Vector3(Konum,i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 200)
                {
                    KonumTutucu = Konum; 
                    Konum = Random.Range(-4.4f,4.4f);
                    if((int)KonumTutucu == (int)Konum)
                    {
                        Konum += Random.Range(2f,3f); 
                    }                    
                    i += 3.6f;
                    Instantiate(Zemin1,new Vector3(Konum,i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 300)
                {
                    KonumTutucu = Konum; 
                    Konum = Random.Range(-4f,4f);
                    if((int)KonumTutucu == (int)Konum)
                    {
                        Konum += Random.Range(2f,2.5f); 
                    }
                    i += 3.6f;
                    Instantiate(Zemin,new Vector3(Konum,i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 400)
                {
                    KonumTutucu = Konum; 
                    Konum = Random.Range(-3.6f,3.6f);
                    if((int)KonumTutucu == (int)Konum)
                    {
                        Konum += Random.Range(1f,2f); 
                    }
                    i += 3.6f;
                    Instantiate(Zemin2,new Vector3(Konum,i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 500)
                {
                    KonumTutucu = Konum; 
                    Konum = Random.Range(-3.2f,3.2f);
                    if((int)KonumTutucu == (int)Konum)
                    {
                        Konum += Random.Range(1f,1.5f); 
                    }
                    i += 3.6f;
                    Instantiate(Zemin3,new Vector3(Konum,i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                
                else if(i < 600)
                {
                    i += 3.6f;
                    Instantiate(Zemin4,new Vector3(Random.Range(-2.8f,2.8f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 700)
                {
                    i += 3.6f;
                    Instantiate(Zemin5,new Vector3(Random.Range(-2.4f,2.4f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 800)
                {
                    i += 3.6f;
                    Instantiate(Zemin6,new Vector3(Random.Range(-2f,2f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 900)
                {
                    i += 3.6f;
                    Instantiate(Zemin7,new Vector3(Random.Range(-2f,2f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 1000)
                {
                    i += 3.6f;
                    Instantiate(Zemin8,new Vector3(Random.Range(-1.8f,1.8f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 1100)
                {
                    i += 3.6f;
                    Instantiate(Zemin9,new Vector3(Random.Range(-1.6f,1.6f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 1200)
                {
                    i += 3.6f;
                    Instantiate(Zemin10,new Vector3(Random.Range(-1.5f,1.5f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 1300)
                {
                    i += 3.6f;
                    Instantiate(Zemin11,new Vector3(Random.Range(-1.4f,1.4f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 1400)
                {
                    i += 3.6f;
                    Instantiate(Zemin12,new Vector3(Random.Range(-1.2f,1.2f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                else if(i < 1500)
                {
                    i += 3.6f;
                    Instantiate(Zemin13,new Vector3(Random.Range(-1f,1f),i),Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }                                  
            }
            else 
            {
                yield return new WaitForSeconds(1f);
            }
            

        }
        
    }
}
