using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text scoretext;
    private int score;

    public void Play(){
        score = 0;
        scoretext.text = score.ToString();
    }
    // Update is called once per frame
    public void IncreaseScore()
    {
        score++;
        scoretext.text = score.ToString();
    }
    public void GameOver(){
        Debug.Log("Game Over");
    }
}
