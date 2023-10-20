using UnityEngine;
using UnityEngine.UI;

public class Bulletss : MonoBehaviour
{
    
    public static int ammo;
    public int my_ammo;
    public GameObject Ammo_txt;

    public static int rp_ammo;
    public int rp_my_ammo;
    public GameObject rp_ammo_txt;

    void Start()
    {
        
    }


    public void Update()
    {
        
        my_ammo = ammo;
        rp_my_ammo = rp_ammo;
        Ammo_txt.GetComponent<Text>().text = (" " + my_ammo);
        rp_ammo_txt.GetComponent<Text>().text = (" " + rp_my_ammo);

    }
}
