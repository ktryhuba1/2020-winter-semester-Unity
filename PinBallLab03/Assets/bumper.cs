using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
    GameState game;
    public int scoreValue, bounceValue;
    Vector3 scale;

    private void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameState");
        game = objs[0].GetComponent<GameState>();
        scale = this.gameObject.GetComponent<Transform>().localScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag.Equals("ball"))
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            this.gameObject.GetComponent<Transform>().localScale = scale * 1.5f;


            Rigidbody2D rgbdy = collision.gameObject.GetComponent<Rigidbody2D>();
            rgbdy.AddForce(bounceValue * collision.relativeVelocity);
            game.score += scoreValue;
            StartCoroutine(Wait(0.25f));
        }
    }

    IEnumerator Wait(float time)
    {
        yield return new WaitForSeconds(time);

        
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        this.gameObject.GetComponent<Transform>().localScale = scale;
    }





}
