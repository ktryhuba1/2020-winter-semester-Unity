using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collider)
    {
        Rigidbody2D rb2d = collider.gameObject.GetComponent<Rigidbody2D>();
        rb2d.AddForce(6 * collider.relativeVelocity);
    }
}
