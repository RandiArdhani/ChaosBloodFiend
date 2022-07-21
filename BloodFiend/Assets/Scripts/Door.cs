using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private PlayerMovement thePlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, WaitingToOpen;

    private bool levelCompleted = false;

    public int nextSceneLoad;
    int levelPassed;


    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WaitingToOpen)
        {
            if (Vector3.Distance(thePlayer.followingKristal.transform.position, transform.position) < 0.1f)
            {
                WaitingToOpen = false;

                doorOpen = true;

                theSR.sprite = doorOpenSprite;

                thePlayer.followingKristal.gameObject.SetActive(false);
                thePlayer.followingKristal = null;
            }
        }

        if(doorOpen && Vector3.Distance(thePlayer.transform.position, transform.position) < 1f && Input.GetAxis("Vertical") > 0.1f)
        {
            CompleteLevel();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (thePlayer.followingKristal != null)
            {
                thePlayer.followingKristal.followTarget = transform;
                WaitingToOpen = true;

                if (WaitingToOpen == true && !levelCompleted)
                {
                    levelCompleted = true;
                    Invoke("CompleteLevel", 2f);
                }
            }
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;

        SceneManager.LoadScene(nextSceneLoad);

        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
    }
}
