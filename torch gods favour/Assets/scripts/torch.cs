using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour

{
    //this allows this script to "talk to" another script
    private GameManager gameManager;
    void Start()
    {
        //this "talks to" a specific component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       //destorys torch and increases the score
        Destroy(gameObject);
             gameManager.UpdateScore(1);
    }
}