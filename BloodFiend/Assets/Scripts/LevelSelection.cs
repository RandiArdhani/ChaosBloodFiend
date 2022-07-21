using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{

    public Button[] lvlButton;
    public static int level = 2;

    // Start is called before the first frame update
    void Start()
    {

        level = PlayerPrefs.GetInt("levelAt", level);

        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < lvlButton.Length; i++)
        {
            if(i + 2 > levelAt)
                lvlButton[i].interactable = false;
        }
    }

    public void Reset()
    {
        level = 2;
        PlayerPrefs.DeleteAll();
    }
}
