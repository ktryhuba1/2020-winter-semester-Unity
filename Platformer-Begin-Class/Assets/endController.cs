using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            GameObject text = GameObject.FindGameObjectWithTag("Finish");
            text.gameObject.GetComponent<Text>().text = "You win!!";

            GameObject button = GameObject.FindGameObjectWithTag("Respawn");
            Vector3 theScale = button.GetComponent<Transform>().localScale;
            theScale.x = 1;
            button.GetComponent<Transform>().localScale = theScale;
        }
    }
}
