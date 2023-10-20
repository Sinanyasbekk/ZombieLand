using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animasyon : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Animation>().Play("Guns");
            Bulletss.ammo -= 1;
        } 
    }
}
