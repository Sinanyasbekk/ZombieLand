using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour
{

    public GameObject vurma;
    public GameObject cross;
    public GameObject trigger;
    public int Sarjor;
    public int YSarjor;
    public int YEkran;

    
    void Update()
    {
        Sarjor = Bulletss.ammo;
        YSarjor = Bulletss.rp_ammo;

        if (YSarjor == 0)
        {
            YEkran = 0;
        }
        else
        {
            YEkran = 10 - Sarjor;
        }
        if(Sarjor < 0)
        {
            trigger.GetComponent<Firing>().enabled = false;
            vurma.GetComponent<Bulletss>().enabled = false;
        }
        else
        {
            trigger.GetComponent<Firing>().enabled = true;
            vurma.GetComponent<Bulletss>().enabled = true;
        }
        if (Input.GetButtonDown("Sarjor"))
        {
            if(YEkran >= 1)
            {
                if(YSarjor <= YEkran)
                {
                    Bulletss.ammo += YSarjor;
                    Bulletss.rp_ammo -= YSarjor;
                    ActionReload();
                }
                else
                {
                    Bulletss.ammo += YEkran;
                    Bulletss.rp_ammo -= YEkran;
                    ActionReload();
                }
            }

            StartCoroutine(EnableScripts());
        }
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.1f);
        cross.SetActive(true);
        trigger.SetActive(true);
    }

    void ActionReload()
    {
        
        cross.SetActive(false);
        trigger.SetActive(false);
    }
}
