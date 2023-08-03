using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager: MonoBehaviour
{
    public static bool pause = false;
    
    public void modePause()
    {
        pause = true;
        Time.timeScale = 0;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
    public void modePlay()
    {
        pause = false;
        Time.timeScale = 1;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

    void start()
    {
        pause = false;
        Time.timeScale = 1;
        modePlay();
    }
}