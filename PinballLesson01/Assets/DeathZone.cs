using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public Transform ballspawnPoint;
    public GameObject ballPrefab;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Destroy(collider.gameObject);
        StartCoroutine(Wait(collider));     
    }

    IEnumerator Wait(Collider2D collider)
    {
        yield return new WaitForSeconds(1);

        collider.transform.position = ballspawnPoint.position;
        collider.attachedRigidbody.velocity = Vector2.zero;

    }
}


