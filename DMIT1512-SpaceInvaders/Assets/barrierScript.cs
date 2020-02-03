using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierScript : MonoBehaviour
{
    float damage = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            damage++;
            if(damage == 1)
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            if (damage == 2)
                gameObject.GetComponent<MeshRenderer>().material.color = Color.black;

            if (damage >= 3)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
