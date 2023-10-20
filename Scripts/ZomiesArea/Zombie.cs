using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;


public class Zombie : MonoBehaviourPunCallbacks
{
    public GameObject Character;
    public GameObject Enemy;
    public float HedefUzakligi, IslemUzakligi = 10, RakipHiz;
    public int SaldiriTetikleyici;
    public RaycastHit Atis;
    public int Attack;

    void Update()
    {

        
        transform.LookAt(Character.transform.position);


            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Atis))
            {
                HedefUzakligi = Atis.distance;
                if (HedefUzakligi < IslemUzakligi)
                {
                    RakipHiz = 0.062f;
                    if (SaldiriTetikleyici == 0)
                    {
                        Enemy.GetComponent<Animation>().Play("Walking");
                    
                    transform.position = Vector3.MoveTowards(transform.position, Character.transform.position, RakipHiz);
                    
                }
                }
                else
                {
                    RakipHiz = 0;
                    Enemy.GetComponent<Animation>().Play("Idle");
                }
            }
            if (SaldiriTetikleyici == 1)
            {
                if (Attack == 0 )
                {
                    
                    StartCoroutine(DusmanHasar());
                }
                RakipHiz = 0;
                Enemy.GetComponent<Animation>().Play("Attacking");
            }
        
        
        
    }
    void OnTriggerEnter()
    {
        SaldiriTetikleyici = 1;
    }

    private void OnTriggerExit()
    {
        SaldiriTetikleyici = 0;
    }

    [PunRPC]
    IEnumerator DusmanHasar()
    {
        
        
        Attack = 1;
        yield return new WaitForSeconds(0.09f);

        KalanCan.OyuncuCan -= 5;
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        Attack = 1;
        
    }
}


