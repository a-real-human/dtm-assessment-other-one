using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endOfLevel2 : MonoBehaviour
{

  // to make collisions detectable and to go to next level/scene
    private void OnTriggerEnter2D(Collider2D other)
    {
        //what scene to load 
        SceneManager.LoadScene("LEVEL 3", LoadSceneMode.Single);
    }
}