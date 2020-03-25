using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public Transform ballSpawnPoint;
    public GameObject ballPrefab;
    GameState gameState;
    public bool deadBall;
    GameObject[] droppers;
    GameObject plunger;
    public float motorpower;


    private void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        gameState = objs[0].GetComponent<GameState>();

        droppers = GameObject.FindGameObjectsWithTag("dropper");

        deadBall = true;
        plunger = GameObject.FindGameObjectWithTag("plunger");

        GameObject newBall = Instantiate(ballPrefab);
        newBall.transform.position = ballSpawnPoint.position;
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag.Equals("ball"))
        {
            deadBall = true;
            gameState.lives -= 1;


            foreach (var flag in droppers)
            {
                flag.GetComponent<MeshRenderer>().enabled = true;
                flag.GetComponent<Collider2D>().enabled = true;
            }

            collider.transform.position = ballSpawnPoint.position;
            collider.attachedRigidbody.velocity = Vector2.zero;
        }
    }

    private void Update()
    {
        if(deadBall)
        {
            if (Input.GetKey(KeyCode.Space))
            {

                plunger.GetComponent<HingeJoint2D>().useMotor = false;
            }
            else
            {
               
                plunger.GetComponent<HingeJoint2D>().useMotor = true;
                
            }

        }

    }

}
