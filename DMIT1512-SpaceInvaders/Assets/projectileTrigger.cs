using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag.Equals("enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
