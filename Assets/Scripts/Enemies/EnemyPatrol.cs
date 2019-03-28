using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    public Transform groundDetection;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        if(groundInfo.collider == false)
        {
            if(movingRight == true)
            {
                transform.eulerAngles =  new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles =  new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
    // // Start is called before the first frame update
    // public Transform myWayPoint1;
    // public Transform myWayPoint2;

    // // public GameObject currentWayPoint;

    // public float moveSpeed = 2.0f;
    

    // void Start()
    // {
        
    // }

    // Update is called once per frame
//     void Update()
//     {
//         var currentWayPoint = myWayPoint1;
//         var moveTo = currentWayPoint.transform.position.x-transform.position.x;
//         if (Mathf.Abs(moveTo) <= 0.05f) {
//      // At waypoint so stop moving
//         GetComponent<Rigidbody2D> ().velocity = new Vector2(0, 0);
//         if(currentWayPoint == myWayPoint2)
//         {
//             currentWayPoint = myWayPoint1;
//         }
//         else
//         {
//             currentWayPoint = myWayPoint1;
//         }
//     }
//     else
//     {
//         GetComponent<Rigidbody2D> ().velocity = new Vector2(GetComponent<Transform> ().localScale.x * moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
//     }
//     }
// }
