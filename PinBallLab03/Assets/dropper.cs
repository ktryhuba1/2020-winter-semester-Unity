using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    GameState game;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        game = objs[0].GetComponent<GameState>();

        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        game.score += scoreValue;
    }
}
