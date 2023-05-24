using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] public float speed = 10f;
    [SerializeField] public float jumpPower = 15f;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform feet;
    [SerializeField] public float sprintSpeed = 4f;
    [SerializeField] public float afterSprintSpeed = 2f;
    [SerializeField] public float cooldown = 3f;
    [SerializeField] public float sprintTime = 6f;

    float mx;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mx = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        CheckGrounded();

        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        else if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    public void FixedUpdate()
    {
        if (Input.GetButton("Run"))
        {
            speed = sprintSpeed;
        }
        else if(Input.GetButtonUp("Run"))
        {
            speed = afterSprintSpeed;
        }

        rb.velocity = new Vector2(mx * speed, rb.velocity.y);
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }

    void CheckGrounded()
    {
        if (Physics2D.OverlapCircle(feet.position, 0.5f, groundLayer))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
