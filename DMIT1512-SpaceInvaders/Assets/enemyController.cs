﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyController : MonoBehaviour
{
    public float speed;
    public float Y;
    public float X;
 

    // Update is called once per frame


    void Update()
    {
     
        transform.Translate(speed * X * Time.deltaTime,Y,0);
        //Debug.Log();
        
    }

}
