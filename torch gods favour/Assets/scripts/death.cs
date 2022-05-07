using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use the scenes stuff i need this

using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    //so it will go to the game over scene when player collides with the gameobject
        private void OnTriggerEnter2D(Collider2D other)
    {
        //what scene to load 
        SceneManager.LoadScene("death scene", LoadSceneMode.Single);
    }
}
