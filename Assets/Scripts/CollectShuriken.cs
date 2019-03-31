using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectShuriken : MonoBehaviour
{
    // public AudioSource collectSound;
    void OnTriggerEnter2D (Collider2D other) {
        if (other.name =="Player")
        {
            Debug.Log("-------sadf-asdfdf------------");
            // collectSound.Play ();
            ScoringSystem.theScore += 50;
            Destroy (gameObject);
        }
        // collectSound.Play ();
        // ScoringSystem.theScore += 50;
        // Destroy (gameObject);
    }
}
