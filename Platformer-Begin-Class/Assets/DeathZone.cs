using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            if(collision.GetComponent<CharacterController>().facingRight == false)
            {
                collision.GetComponent<CharacterController>().Flip();
            }
            SceneManager.LoadScene(0);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
