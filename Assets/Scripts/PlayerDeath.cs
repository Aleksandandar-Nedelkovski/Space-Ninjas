using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public LevelManager levelManager;
    public NewBehaviourScript player;
    public int damage =1;

    // public Heart damage;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        player = FindObjectOfType<NewBehaviourScript>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            //var deathSecene = new PlayerAttack;
            levelManager.RespawnPlayer();
            if(player.health <= 0)
            {
                Application.LoadLevel(1);
            }
        }
    }
}
