using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    public int upperRandomRange = 2;
    public float Offsetx = 0, Offsety = 0, Offsetz = 0;

    void Update()
    {
        //transform.position.Set(Offsetx + transform.position.x, transform.position.y + Offsety, transform.position.z + Offsetz);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject projectile = Instantiate(projectilePrefab);
            projectile.transform.position = transform.position;

        }
    }
    private void OnDrawGizmos()
    {
        transform.position.Set(Offsetx + transform.position.x, transform.position.y + Offsety, transform.position.z + Offsetz);
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, 0.1f);
    }

}
