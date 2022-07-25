using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Spear")
        {
            GameOverlay.isGameOver = true;
            gameObject.SetActive(false);
        }
    }
}
