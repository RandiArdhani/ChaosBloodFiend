using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelletePlayerPrefs : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}

