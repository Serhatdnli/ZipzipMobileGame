using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminDestroyer : MonoBehaviour
{
    public ZeminOlusturma Erisim;
    void Start()
    {
        //if(gameObject.position.y < Erisim.Player.position.y)
        //{
            Destroy(gameObject,25);
        //}
    }
}
