using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    public float jump;
    private Animator animator;
    private bool landed;

    public Transform kristalFollowPoint;
    public Kristal followingKristal;

    [SerializeField] private AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hInput * speed, rb.velocity.y);

        if (hInput > 0.01f)
            transform.localScale = new Vector2(2, 2);
        else if (hInput < -0.01f)
            transform.localScale = new Vector2(-2, 2);

        if (Input.GetKey(KeyCode.Space) && landed)
        {
            jumpSound.Play();
            Jump();
        }

        if (Input.GetKey(KeyCode.UpArrow) && landed)
        {
            jumpSound.Play();
            Jump();
        }

        animator.SetBool("run", hInput != 0);
        animator.SetBool("landed", landed);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jump);
        animator.SetTrigger("jump");
        landed = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            landed = true;
    }
}
