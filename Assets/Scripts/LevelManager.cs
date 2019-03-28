using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckPoint;
    private NewBehaviourScript player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<NewBehaviourScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer()
    
    {
        Debug.Log("Player respawn");
        player.transform.position = currentCheckPoint.transform.position;
    }
}
