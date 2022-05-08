using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public List<GameObject> torches;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
     
    }

    public void UpdateScore(int scoreToAdd)
    {
        scoreText.text = "Score: " + score;
    }
}
  
