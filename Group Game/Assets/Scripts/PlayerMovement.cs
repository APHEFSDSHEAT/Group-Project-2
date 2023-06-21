using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Interaction interaction;
    [SerializeField] int health = 3;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] public float speed = 10f;
    [SerializeField] public float jumpPower = 15f;
    [SerializeField] LayerMask groundLayer;
    //[SerializeField] Transform feet;
    BoxCollider2D myFeetColliders;
    [SerializeField] public float sprintSpeed = 4f;
    [SerializeField] public float afterSprintSpeed = 2f;
    [SerializeField] public float sprintCooldown = 2f;
    [SerializeField] public float sprintingTime = 4f;
    bool sprintTimeCooldown = true;
    bool sprintTime = false;
    public Animator animator;

    float mx;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        interaction = FindObjectOfType<Interaction>();
        myFeetColliders = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(mx));

        if (interaction.inCloset == false)
        {
            mx = Input.GetAxisRaw("Horizontal");
        }

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

        CheckGrounded();

        if (Input.GetButtonDown("Jump") && interaction.inCloset == false)
        {
            Jump();
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

        if(mx != 0) 
        {
            rb.AddForce(new Vector2(mx * speed, 0f));
        }

        if (mx > 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

        if (mx < 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
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
        if (myFeetColliders.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (interaction.inCloset == false)
        {
            DamageDealer otherDamageDealer = other.gameObject.GetComponent<DamageDealer>();
            if (!otherDamageDealer) { return; }
            ProcessHit(otherDamageDealer);
        }

    }

    private void ProcessHit(DamageDealer otherDamageDealer)
    {
        health -= otherDamageDealer.GetDamage();
        otherDamageDealer.Hit();
        if (health <= 0)
        {
            Destroy(gameObject);
            if (otherDamageDealer.tag == "Water")
            {
                FindObjectOfType<SceneLoader>().Drowning();
            }
            if (otherDamageDealer.tag == "Mr Tie")
            {
                FindObjectOfType<SceneLoader>().LoseScene();
            }
        }
    }
}
