
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControllerScript : MonoBehaviour
{

    GameState gamestate;

    private void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        gamestate = objs[0].GetComponent<GameState>();
    }


    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }




}
