using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text vidas;
    public Text score;
    public int startLife = 5;
    public static GameManager instance;

    private int currentScore;
    private int currentLifes;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        currentScore = 0;
        currentLifes = startLife;

        score.text = "SCORE: " + currentScore;
        vidas.text = "Vidas: " + startLife;
    }

    public void incrScore(int incr)
    {
        currentScore += incr;
        score.text = "SCORE: " + currentScore;
    }

    public void decrLifes()
    {
        currentLifes--;
        vidas.text = "Vidas: " + currentLifes;
    }
}
