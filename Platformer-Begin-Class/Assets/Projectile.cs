using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    void Update()
    {
        transform.Translate(speed * direction * Time.deltaTime);
    }
}
