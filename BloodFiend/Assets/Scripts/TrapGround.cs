using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGround : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D boxCollider;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Invoke("DropPlatform", 0.5f);
            Destroy(gameObject, 0.1f);
        }
    }

    void DropPatform()
    {
        rb.isKinematic = false;
    }
}
