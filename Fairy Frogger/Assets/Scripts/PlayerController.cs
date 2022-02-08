using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;

    public float speed;
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        float dirY = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirY * 7f, rb.velocity.x);

    }

}
