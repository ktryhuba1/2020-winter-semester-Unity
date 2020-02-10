using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterDisplay : MonoBehaviour
{
    GameState theGameState;
    int score;
    private void Awake()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("GameState");
        theGameState = gameObjects[0].GetComponent<GameState>();

        score = theGameState.counter;
    }
    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Text>().text = this.gameObject.GetComponent<Text>().text + score; 
    }
}
