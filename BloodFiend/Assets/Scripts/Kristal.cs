using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kristal : MonoBehaviour
{
    private bool isFollowing;
    public float followSpeed;
    public Transform followTarget;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!isFollowing)
            {
                PlayerMovement thePlayer = FindObjectOfType<PlayerMovement>();

                followTarget = thePlayer.kristalFollowPoint;

                isFollowing = true;
                thePlayer.followingKristal = this;
            }
        }
    }
}
