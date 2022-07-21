using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageDelet : MonoBehaviour
{
    public Button level2btn, level3btn, level4btn, level5btn;
    int levelPassed;
    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("levelAt");
        level2btn.interactable = false;
        level3btn.interactable = false;
        level4btn.interactable = false;
        level5btn.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level2btn.interactable = false;
                break;
            case 2:
                level2btn.interactable = false;
                level3btn.interactable = false;
                level4btn.interactable = false;
                level5btn.interactable = false;
                break;
        }
    }

    public void levelToLoad (int nextSceneLoad)
    {
        SceneManager.LoadScene(nextSceneLoad);
    }

    public void Reset()
    {
        level2btn.interactable = false;
        level3btn.interactable = false;
        level4btn.interactable = false;
        level5btn.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
