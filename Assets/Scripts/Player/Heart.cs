using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHearth;
    public Sprite emptyHearth;

    void Start()
    {
        health = GetComponent<NewBehaviourScript>().health;
        // numOfHearts = health;
    }
    void Update() 
    {
        health = GetComponent<NewBehaviourScript>().health;
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHearth;
            }
            else
            {
                hearts[i].sprite = emptyHearth;
            }
            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
