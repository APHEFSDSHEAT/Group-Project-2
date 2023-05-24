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
    [SerializeField] public float sprintCooldown = 2f;
    [SerializeField] public float sprintingTime = 4f;
    bool sprintTimeCooldown = true;
    bool sprintTime = false;

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

        if (Input.GetButton("Run") && sprintTimeCooldown == true)
        {
            sprintTime = true;
            sprintingTime -= Time.deltaTime;
            if(sprintCooldown <= 0f)
            {
                speed = sprintSpeed;
            }
            if(sprintingTime <= 0f)
            {
                speed = afterSprintSpeed;
            }
        }
        else if (Input.GetButtonUp("Run") && sprintTimeCooldown == true)
        {
            speed = afterSprintSpeed;
            sprintTimeCooldown = false;
            sprintCooldown = 2f;
            sprintTime = false;
            sprintingTime = 4f;
        }

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

        sprintCooldown -= Time.deltaTime;
        if(sprintCooldown <= 0f)
        {
            sprintTimeCooldown = true;
        }
    }



    public void FixedUpdate()
    {
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
