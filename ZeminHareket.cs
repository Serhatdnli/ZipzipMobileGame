using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminHareket : MonoBehaviour
{   
    public PlayerController yukseklikkontrol;
    public bool emir = false;

    public float zeminhizi;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        if(yukseklikkontrol.karakter.position.y>5)
        {   
            emir=true;

        }
        if(emir)
        {
            transform.position += Vector3.down * zeminhizi * Time.deltaTime;
        }
    }
}
