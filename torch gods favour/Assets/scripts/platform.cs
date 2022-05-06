using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    // Platform Effector2d to make platoforms work as platforms
    private PlatformEffector2D effector;
    
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    { 
    if (Input.GetKeyUp(KeyCode.DownArrow) && Input.GetKeyUp(KeyCode.S))
        {
            effector.rotationalOffset = 0f;
        }       
    if (Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {
            effector.rotationalOffset = 180f;
        }
    }
}
