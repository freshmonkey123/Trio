using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersScoreCounter : MonoBehaviour
{
    private int score = 1;

    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    void Update()
    {
        
    }

    public int getScore()
    {
        return score;
    }

    public void upScore(int score)
    {
        this.score += score;
    }
}
