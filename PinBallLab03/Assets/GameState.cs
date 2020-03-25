using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class GameState : MonoBehaviour
{

    public int score, highscore, lives;

    public string message;

    private void Awake()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("GameState");
        if(gameObjects.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            LoadHighScore();
        }
               
    }



    public void SaveHighScore()
    {
        string dataPath = Path.Combine(Application.persistentDataPath, "GameSaves.txt");

        string jsonString = JsonUtility.ToJson(this);

        using (StreamWriter streamWriter = File.CreateText(dataPath))
        {
            streamWriter.Write(jsonString);
        }
    }

    public void LoadHighScore()
    {
        string dataPath = Path.Combine(Application.persistentDataPath, "GameSaves.txt");

        using (StreamReader streamReader = File.OpenText(dataPath))
        {
            string jsonString = streamReader.ReadToEnd();

            GameState gameStateReadFromDisk = new GameState();

            JsonUtility.FromJsonOverwrite(jsonString, gameStateReadFromDisk);


            this.highscore = gameStateReadFromDisk.highscore;

        }


    }



}
