using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleController : MonoBehaviour
{
    //any game object that needs to access the game state(for read or write) follow this patten
    GameState gameState;

    public void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        gameState = objs[0].GetComponent<GameState>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, gameState.rotationVelocity * Time.deltaTime, 0);
    }
}
