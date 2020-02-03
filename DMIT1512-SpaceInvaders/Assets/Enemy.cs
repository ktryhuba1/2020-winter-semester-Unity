using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float y;

    public void OnTriggerEnter2D(Collider2D collider2D)
    {


        if (collider2D.gameObject.tag.Equals("Wall"))
        {
            y -= 0.1f;
            gameObject.transform.parent.GetComponent<enemyController>().X *= -1;
            gameObject.transform.parent.GetComponent<Transform>().Translate(0,y,0);
        }
    }
}
