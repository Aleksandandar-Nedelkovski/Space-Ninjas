using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxSpeed = 10f;
    public int meleeDamage = 1;
    public bool attacked = false;

    public Rigidbody2D body2D;
    bool facingRight = true;

    Animator anim;
    bool grounded = false;

    public Transform groundCheck;

    float groundRadius = 0.2f;

    public LayerMask whatIsGround;
    public float jumpForce = 1000f;
    bool doubleJump = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Awake()

    {
        body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (grounded)
            doubleJump = false;
        anim.SetBool("Ground", grounded);
        anim.SetFloat("vSpeed", body2D.velocity.y);

        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Run", Mathf.Abs(move));

        // rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
        body2D.velocity = new Vector2(move * maxSpeed, body2D.velocity.y);


        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Update()
    {
        if (grounded)
        {
            jumpForce = 1000f;
        }
        if (!grounded)
        {
            jumpForce = 700f;
        }
        if ((grounded || !doubleJump) && Input.GetKeyDown(KeyCode.Space))
        {
            // jumpForce =1000f;
            anim.SetBool("Ground", false);
            body2D.AddForce(new Vector2(0, jumpForce));
            // jumpForce=500f;
            if (!doubleJump && !grounded)
                doubleJump = true;
        }
        if (Input.GetButtonDown("Attack"))
        {
            anim.SetTrigger("Attack");
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
