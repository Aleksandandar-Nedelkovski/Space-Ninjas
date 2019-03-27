using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour
{
    public int Health;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage()
    {
        Health -= 1;
        if(Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
