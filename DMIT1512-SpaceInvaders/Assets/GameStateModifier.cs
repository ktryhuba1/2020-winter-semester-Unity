using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameStateModifier : MonoBehaviour
{

    internal int enemyCount,lastEnemyCount,score,health;
    GameObject scoreTextBox, healthTextBox;

    internal enum GameStates
    {
        play,
        won,
        lost

    }
   // internal GameStates currentGamestate;

    // Start is called before the first frame update
    void Start()
    {
        // enemyCount = ;
        //currentGamestate = GameStates.play;
        GameObject.FindGameObjectWithTag("Win").GetComponent<Canvas>().scaleFactor = 0;
        GameObject.FindGameObjectWithTag("Loss").GetComponent<Canvas>().scaleFactor = 0;
        scoreTextBox = GameObject.FindGameObjectWithTag("score");
        healthTextBox = GameObject.FindGameObjectWithTag("health");

        score = 0;
        health = 3;
        lastEnemyCount = GameObject.FindGameObjectsWithTag("enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("enemy").Length;

        if(enemyCount != lastEnemyCount)
        score += 5;



        scoreTextBox.GetComponent<Text>().text = "Score: " + score;
        healthTextBox.GetComponent<Text>().text = "Health: " + health;

        lastEnemyCount = enemyCount;
    }
}
