using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //how many torches there are in the level
    public int Torches = 4;
    //this allows this script to detect when the torches are collected
    public List<GameObject> TorchesAtStart;
    //method to detect how many torches remain
    public void UpdateTorches(int TorchesLeft)
    {
        //this counts the amount of torches required to be collected before the player is allowed to move on to the next level
        Torches += TorchesLeft;
        if (Torches == 0)
        {
            //this effectively opens the "door" and allows the player to go to the next level
            Destroy(gameObject);
        }
    }
}
