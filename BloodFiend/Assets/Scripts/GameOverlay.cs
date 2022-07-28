using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverlay : MonoBehaviour
{

    public static bool isGameOver;
    public GameObject gameOverScreen;
    public static int numberOfCoins;
    public TextMeshProUGUI coinText;

    public void Awake()
    {
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
        
        isGameOver = false;
    }

    void Update()
    {
        coinText.text = numberOfCoins.ToString();

        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
}
