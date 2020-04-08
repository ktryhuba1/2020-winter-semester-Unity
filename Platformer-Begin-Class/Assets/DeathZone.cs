using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Equals("groundCheck"))
        {
            //go to game over 
        }

        Destroy(collision.gameObject);
    }
}
