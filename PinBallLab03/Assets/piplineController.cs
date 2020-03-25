using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piplineController : MonoBehaviour
{
    public Transform ballSpawnPoint;
    public float time;
    DeathZone deathbool;


    private void Start()
    {
        GameObject obj = GameObject.Find("DeathZone");
        deathbool = obj.GetComponent<DeathZone>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("ball"))
        {

            time = time - (0.01f * collision.attachedRigidbody.velocity.y);

            StartCoroutine(Wait(time, collision));
        }
    }


    IEnumerator Wait(float time, Collider2D collision)
    {
        yield return new WaitForSeconds(time);

        collision.GetComponent<Transform>().position = ballSpawnPoint.position;
        deathbool.deadBall = false;
    }
}
