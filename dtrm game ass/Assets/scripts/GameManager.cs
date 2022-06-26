using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //declaring the score variable 
    private int score;
    //to display the score
    public TextMeshProUGUI scoreText;
    //detect when the torches are collected
    public List<GameObject> torches;
    // Start is called before the first frame update
    void Start()
    {
        //setting the score variable to zero
        score = 0;
     
    }
    //TO UPDATE SCORE
    public void UpdateScore(int scoreToAdd)
    {
        //increases the score
        score += scoreToAdd;
        //displaying the score on the ui
        scoreText.text = "Score: " + score;
    }
}
  
