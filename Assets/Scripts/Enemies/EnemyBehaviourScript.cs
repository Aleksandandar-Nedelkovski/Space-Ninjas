using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour
{
    // public int Health;
    // public Animator anim;
    public LayerMask enemyMask;
    Rigidbody2D myBody;
    Transform myTrans;
    float myWidth;
    public float speed = 1;
    void Start()
    {
        //anim = GetComponent<Animator>();
        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Vector2 lineCastPos = myTrans.position - myTrans.right * myWidth;
        // Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down); 
        // bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);

        // if(!isGrounded)
        // {
        //     Vector3 currentRot = myTrans.eulerAngles;
        //     currentRot.y += 180;
        //     myTrans.eulerAngles = currentRot;
        // }

        // Vector2 myVel = myBody.velocity;
        // myVel.x = -myTrans.right.x * speed;
        // myBody.velocity =myVel;
    }

    // void TakeDamage()
    // {
    //     Health -= 1;
    //     if(Health == 0)
    //     {
    //         Destroy(gameObject);
    //     }
    // }
}
