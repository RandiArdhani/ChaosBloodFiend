using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelletePlayerPrefs : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Home(int sceneID)
    {
       
            SceneManager.LoadScene(sceneID);
        
        
    }
}

