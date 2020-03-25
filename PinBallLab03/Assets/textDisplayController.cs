using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textDisplayController : MonoBehaviour
{

    GameState game;
    GameObject scoreDisplay, livesDisplay, highscoreDisplay, messageDisplay;
    

    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        game = objs[0].GetComponent<GameState>();

        scoreDisplay = GameObject.FindGameObjectWithTag("Score");
        livesDisplay = GameObject.FindGameObjectWithTag("Lives");
        highscoreDisplay = GameObject.FindGameObjectWithTag("highScore");
        messageDisplay = GameObject.FindGameObjectWithTag("message");



    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "SCORE: " + game.score;

        if(livesDisplay != null)
        livesDisplay.GetComponent<Text>().text = "LIVES: " + game.lives;


        if(highscoreDisplay != null)
        {


            if(game.highscore < game.score)
            {
                game.highscore = game.score;
                game.message = "New HighScore!";
                game.SaveHighScore();
            }
            highscoreDisplay.GetComponent<Text>().text = "HIGHSCORE: " + game.highscore;
        }


        if(messageDisplay != null)
        messageDisplay.GetComponent<Text>().text = game.message;



    }
}
