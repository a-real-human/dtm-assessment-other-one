using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endOfLevelEASY : MonoBehaviour
{

  // to make collisions detectable and to go to next level/scene
    private void OnTriggerEnter2D(Collider2D other)
    {
        //what scene to load 
        SceneManager.LoadScene("EASY LEVEL", LoadSceneMode.Single);
    }
}