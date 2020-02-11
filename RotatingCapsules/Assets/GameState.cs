using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public float rotationVelocity;

    private void Awake()
    {
        GameObject[] gameobjects = GameObject.FindGameObjectsWithTag("GameState"); 
        if(gameobjects.Length > 1)
        { 
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }


    public void ChangeGameRotationVelocity(float rotationVelocity)
    {
        if (rotationVelocity != 0)
        {
            this.rotationVelocity += rotationVelocity;
        }
        else
        {
            this.rotationVelocity *= 0;
        }
    }

    private void Update()
    {
        
    }
}
