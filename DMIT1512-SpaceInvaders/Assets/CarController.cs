using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public float speed = 1;

    protected bool leftReached = false;
    protected bool rightReached = false;
    protected bool alive = true;
    protected int enemyCount,parentCount,index, score;
    protected float timer;
    protected GameStateModifier gameState;

    private void Start()
    {
        score = 0;
        timer = 0;
        index = SceneManager.GetActiveScene().buildIndex;
        gameState = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateModifier>();
        gameState.health = 3;
    }

    void Update()
    {
       if(alive)
        {
            float xDirection = Input.GetAxis("Horizontal");
            Vector3 translation = new Vector3(speed * xDirection, 0, 0);

            if (rightReached == false && translation.x > 0)
            {
                transform.Translate(translation * Time.deltaTime, Space.Self);
                leftReached = false;
            }
            //moving 
            if (leftReached == false && translation.x < 0)
            {
                transform.Translate(translation * Time.deltaTime, Space.Self);
                rightReached = false;
            }
            enemyCount = GameObject.FindGameObjectsWithTag("enemy").Length;
            GameObject.FindGameObjectWithTag("enemyCount").GetComponent<Text>().text = "Ships: " + enemyCount;


            if (enemyCount == 0)
            {
                timer += Time.deltaTime;
                GameObject.FindGameObjectWithTag("Win").GetComponent<Canvas>().scaleFactor = 1;

                if (timer > 3)
                {
                    if (index < 2)
                    {
                        SceneManager.LoadScene(index + 1);
                    }
                    else
                    {
                        SceneManager.LoadScene(0);
                    }
                }
                
            }
            

        }
       else
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Loss").GetComponent<Canvas>().scaleFactor = 1;
           // GameObject.FindGameObjectWithTag("score").GetComponent<Text>()
        }

    }
    private void OnTriggerEnter2D(Collider2D theThingIJustBumpedInto)
    {

        gameState = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameStateModifier>();
        if (theThingIJustBumpedInto.gameObject.name.Equals("Wall (1)"))
        {
            rightReached = true;
        }
        if (theThingIJustBumpedInto.gameObject.name.Equals("Wall"))
        {
            leftReached = true;
        }
        if(theThingIJustBumpedInto.gameObject.tag.Equals("Bullet"))
        {
            
            gameState.health--;
            Destroy(theThingIJustBumpedInto.gameObject);


            if (gameState.health <= 0)
            {
                alive = false;
            }

        }
        if(theThingIJustBumpedInto.gameObject.tag.Equals("enemy"))
        {
            gameState.health = 0;
            alive = false;
        }

    }
}
