using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    public GameObject Zombi;
    

    public void Enemies(int damage)
    {
        enemyHealth -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (enemyHealth <=0)
        {
            this.GetComponent<Zombie>().enabled = true;
            Zombi.GetComponent<Animation>().Play("Dying");
            StartCoroutine(LastZombie());
            Destroy(gameObject);
        }
    }

    IEnumerator LastZombie()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
