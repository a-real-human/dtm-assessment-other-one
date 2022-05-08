using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnCollision : MonoBehaviour

{
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        Destroy(gameObject);
         gameManager.UpdateScore(1);
    }
}