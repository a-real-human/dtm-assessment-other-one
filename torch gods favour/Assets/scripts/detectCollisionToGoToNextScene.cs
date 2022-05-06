using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectCollisionToGoToNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // to make collisions detectable and to go to next level/scene
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("tutorial", LoadSceneMode.Single);
    }
}
