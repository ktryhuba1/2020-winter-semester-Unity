using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public Transform ballspawnPoint;
    public GameObject ballPrefab;

    private void Start()
    {
        GameObject newBall = Instantiate(ballPrefab);
        newBall.transform.position = ballspawnPoint.position;
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag.Equals("ball"))
        StartCoroutine(Wait(collider));     
    }

    IEnumerator Wait(Collider2D collider)
    {
        yield return new WaitForSeconds(1);

        collider.transform.position = ballspawnPoint.position;
        collider.attachedRigidbody.velocity = Vector2.zero;

    }
}


