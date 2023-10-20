using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public int damage = 5;
    public float aim_distance;
    public float giving_distance = 15;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit Atis = new RaycastHit();

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Atis))
            {
                aim_distance = Atis.distance;
                if (aim_distance < giving_distance)
                {
                    Atis.transform.SendMessage("Enemies", damage);
                }
            }
        }
    }

    
}
