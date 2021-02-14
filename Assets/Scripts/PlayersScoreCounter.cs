using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersScoreCounter : MonoBehaviour
{
    private int score = 0;

    void Start()
    {
        
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
