using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraYonetim : MonoBehaviour
{
    
    public Transform hedef1,hedef2,hedef3,hedef4;
    public float kamerahizi;

    void Update()
    {
        if(VeriYonetimi.kayit.secilenKarakter == 0)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(hedef1.position.x,(hedef1.position.y+2f),transform.position.z), kamerahizi);
        }
        else if(VeriYonetimi.kayit.secilenKarakter == 1)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(hedef2.position.x,(hedef2.position.y+2f),transform.position.z), kamerahizi);
        }
        else if(VeriYonetimi.kayit.secilenKarakter == 2)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(hedef3.position.x,(hedef3.position.y+2f),transform.position.z), kamerahizi);
        }
        else if(VeriYonetimi.kayit.secilenKarakter == 3)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(hedef4.position.x,(hedef4.position.y+2f),transform.position.z), kamerahizi);
        }
        /*else if(VeriYonetimi.kayit.secilenKarakter == 4)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(hedef5.position.x,(hedef5.position.y+2f),transform.position.z), kamerahizi);
        }*/
    }
}
