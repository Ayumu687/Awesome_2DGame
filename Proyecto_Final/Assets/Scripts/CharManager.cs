using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    public static int User = 4;
    private static bool Start = false;
    // Update is called once per frame
    void Update()
    {
        if (User != 4)
        {
            gameObject.transform.GetChild(User).gameObject.SetActive(true);
        }
    }
}
