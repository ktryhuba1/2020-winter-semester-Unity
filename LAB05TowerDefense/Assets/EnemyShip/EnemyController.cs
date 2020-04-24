using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public float speed;

    //this example uses sprites from "Spaceship Construction Spirtes Set" on unity asset store
    void Update ()
    {
		transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        Vector3 moveDirection = gameObject.transform.position - target.position;
        if (moveDirection != Vector3.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //it's working exactly as I want, except it needs to be flipped by 180 degrees on the z axis.
            transform.RotateAround(transform.position, transform.forward, 180f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Bullet"))
        {
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag.Equals("Finish"))
        {
            collision.gameObject.SetActive(false);
            
            GameObject textbox = GameObject.FindGameObjectWithTag("Message");
            textbox.GetComponent<Text>().text = "You Lost";
            StartCoroutine(Wait());            
        }
    }

    protected IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }

}
