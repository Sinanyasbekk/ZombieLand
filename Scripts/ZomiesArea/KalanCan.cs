using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

[RequireComponent(typeof(CharacterController))]
public class KalanCan : MonoBehaviourPunCallbacks
{
    public static int OyuncuCan = 100;
    public int icCan;
    public GameObject HealtPoint;
    
    void Update()
    {
       
        icCan = OyuncuCan;
        HealtPoint.GetComponent<Text>().text = "Health: " + OyuncuCan;
        Death();
    }

    void Death()
    {
        
       
        if (OyuncuCan == 0 )
        {

           SceneManager.LoadScene(2);
        }
        
    }
}
