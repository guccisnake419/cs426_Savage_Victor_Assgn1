using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    public int maxscore= 5;

    public int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score: "+ score;
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score++;
        
        if (score <= maxscore){
            
            scoreText.text = "Score: "+score;
        }
        else
        {
            scoreText.text = "You won!";
            score= 0;
        }
            
    }
}
