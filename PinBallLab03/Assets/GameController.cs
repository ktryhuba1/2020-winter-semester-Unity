using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    GameState game;
    int score,highscore, lives;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        game = objs[0].GetComponent<GameState>();

        game.score = 0;
        game.lives = 3;

        GameObject[] walls = GameObject.FindGameObjectsWithTag("wall");

        GameObject[] paddles = GameObject.FindGameObjectsWithTag("Player");

        GameObject[] bouncers = GameObject.FindGameObjectsWithTag("bouncer");


        foreach (var wall in walls)
        {
            wall.GetComponent<MeshRenderer>().material.color = Color.magenta;
        }

        foreach (var paddle in paddles)
        {
            paddle.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        foreach (var wall in bouncers)
        {
            wall.GetComponent<MeshRenderer>().material.color = Color.black;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(game.lives <= 0)
        {
            GameOver();
        }
    }



    void GameOver()
    {
        game.message = "Game Over";
        SceneManager.LoadScene(0);
    }


}
