using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timerrr : MonoBehaviour
{
    public float zaman, verilenzaman;
    public Text Timer;

    public Text countText;
    public float count;

    

    

    [System.Obsolete]
    void Start()
    {
        zaman = verilenzaman;
        count = 0;
        
    }
    void Update()
    {
        zaman -= Time.deltaTime;
        Timer.text = zaman.ToString("f2");
        countText.text = "Skor: " + count.ToString();
        
        if (zaman <= 0)
        {
            zaman = verilenzaman;
            Time.timeScale = 0;
            SceneManager.LoadScene(3);

        }
    }

    
}
