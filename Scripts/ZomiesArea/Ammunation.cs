using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Ammunation : MonoBehaviourPunCallbacks
{

    public void OnTriggerEnter(Collider other)
    {
        
            if (Bulletss.ammo == 0)
            {
                Bulletss.ammo += 15;
                this.gameObject.SetActive(false);
            }
            else
            {
                Bulletss.rp_ammo += 15;
                this.gameObject.SetActive(false);
            }    
    }
}
