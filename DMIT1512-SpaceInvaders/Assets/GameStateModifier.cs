using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameStateModifier : MonoBehaviour
{

    internal int enemyCount,lastEnemyCount,score = 0,health;
    GameObject scoreTextBox, healthTextBox;
    GameObject objScore,objHealth;

    internal enum GameStates
    {
        play,
        won,
        lost

    }
    // internal GameStates currentGamestate;
    private void Awake()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("GameController");
        if (gameObjects.Length > 1)
        {
            Destroy(this.gameObject);
            InitializeLevel();
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);            
        }
   

    }
   
    // Start is called before the first frame update
    void Start()
    {
        //InitializeLevel();
        GameObject.FindGameObjectWithTag("Win").GetComponent<Canvas>().scaleFactor = 0;
        GameObject.FindGameObjectWithTag("Loss").GetComponent<Canvas>().scaleFactor = 0;

        objScore = GameObject.FindGameObjectWithTag("score");
        objHealth = GameObject.FindGameObjectWithTag("health");


        scoreTextBox = objScore;
        healthTextBox = objHealth;

        //  score = 0;
        health = 3;
        lastEnemyCount = GameObject.FindGameObjectsWithTag("enemy").Length;

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("enemy").Length;

        if ((enemyCount < lastEnemyCount) && SceneManager.GetActiveScene().buildIndex != 0)
        {
            score += 5;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            score = 0;
        }
        objScore = GameObject.FindGameObjectWithTag("score");
        objHealth = GameObject.FindGameObjectWithTag("health");

        if (objScore != null && objHealth != null)
        {
            scoreTextBox = objScore;
            healthTextBox = objHealth;
            
            scoreTextBox.GetComponent<Text>().text = "Score: " + score;
            healthTextBox.GetComponent<Text>().text = "Health: " + health;
        }
        lastEnemyCount = enemyCount;
    }

    void InitializeLevel()
    {
        GameObject.FindGameObjectWithTag("Win").GetComponent<Canvas>().scaleFactor = 0;
        GameObject.FindGameObjectWithTag("Loss").GetComponent<Canvas>().scaleFactor = 0;

       
        //this.score = score;
        health = 3;
        lastEnemyCount = GameObject.FindGameObjectsWithTag("enemy").Length;
    }
}
