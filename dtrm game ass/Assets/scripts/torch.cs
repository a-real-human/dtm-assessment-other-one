using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour

{
    //this allows this script to "talk to" another script
    private GameManager gameManager;
    private Door door;
    void Start()
    {
        //this "talks to" a specific component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        door = GameObject.Find("gateway").GetComponent<Door>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       //destorys torch and increases the score
        Destroy(gameObject);
        door.UpdateTorches(-1);
        gameManager.UpdateScore(1);
    }
}