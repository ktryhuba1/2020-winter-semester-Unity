using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projectilePrefab;

    public int upperRandomRange = 2;
    public float Offsetx = 0, Offsety = 0, Offsetz = 0;

    

    void Update()
    {
        transform.position.Set(Offsetx + transform.position.x, transform.position.y + Offsety, transform.position.z + Offsetz); 
        int random = Random.Range(1, upperRandomRange);
        if(random == 1)
        {
            GameObject projectile = Instantiate(projectilePrefab);
            projectile.transform.position = transform.position;

        }
    }




}
