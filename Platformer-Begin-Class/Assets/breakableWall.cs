using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Bullet"))
        { 
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
