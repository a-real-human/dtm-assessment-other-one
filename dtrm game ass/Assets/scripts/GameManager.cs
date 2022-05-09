using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //score
    private int score;
    //to display the score
    public TextMeshProUGUI scoreText;
    //detect when the torches are collected
    public List<GameObject> torches;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
     
    }

    public void UpdateScore(int scoreToAdd)
    {
        //increases the score
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
  