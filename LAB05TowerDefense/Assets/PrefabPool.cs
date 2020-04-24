using System.Collections.Generic;
using UnityEngine;

public class PrefabPool : MonoBehaviour
{
    private void Awake()
    {
        InitializeProjectiles();
        InitializeEnemies();
        InitializeTurrets();
        InitializeBlooms();
    }

    public int numBloomsInScene;
    public Transform BloomPrefab;
    protected Transform[] BloomPrefabPool = new Transform[0];


    public void InitializeBlooms()
    {
        if (BloomPrefabPool.Length == 0)
        {
            BloomPrefabPool = new Transform[numBloomsInScene];
            for (int c = 0; c < numBloomsInScene; c++)
            {
                BloomPrefabPool[c] = Instantiate(BloomPrefab);
                BloomPrefabPool[c].gameObject.SetActive(false);
            }
        }
    }


    public Transform Bloom
    {
        get
        {
            Transform returnTransform = null;
            int c = 0;
            while (c < BloomPrefabPool.Length && returnTransform == null)
            {
                if (!BloomPrefabPool[c].gameObject.activeInHierarchy)
                {
                    returnTransform = BloomPrefabPool[c];
                    BloomPrefabPool[c].gameObject.SetActive(true);
                }
                c++;
            }

            return returnTransform;
        }
    }


    public int numTurretsInScene;
    public Transform TurretPrefab;
    protected Transform[] TurretPrefabPool = new Transform[0];


    public void InitializeTurrets()
    {
        if (TurretPrefabPool.Length == 0)
        {
            TurretPrefabPool = new Transform[numTurretsInScene];
            for (int c = 0; c < numTurretsInScene; c++)
            {
                TurretPrefabPool[c] = Instantiate(TurretPrefab);
                TurretPrefabPool[c].gameObject.SetActive(false);
            }
        }
    }


    public Transform Turret
    {
        get
        {
            Transform returnTransform = null;
            int c = 0;
            while (c < TurretPrefabPool.Length && returnTransform == null)
            {
                if (!TurretPrefabPool[c].gameObject.activeInHierarchy)
                {
                    returnTransform = TurretPrefabPool[c];
                    TurretPrefabPool[c].gameObject.SetActive(true);
                }
                c++;
            }

            return returnTransform;
        }
    }


    public int numEnemiesInScene;
    public Transform enemyPrefab;
    protected Transform[] enemyPrefabPool = new Transform[0];


    public void InitializeEnemies()
    {
        if (enemyPrefabPool.Length == 0)
        {
            enemyPrefabPool = new Transform[numEnemiesInScene];
            for (int c = 0; c < numEnemiesInScene; c++)
            {
                enemyPrefabPool[c] = Instantiate(enemyPrefab);
                enemyPrefabPool[c].gameObject.SetActive(false);
            }
        }
    }


    public Transform Enemy
    {
        get
        {
            Transform returnTransform = null;
            int c = 0;
            while(c < enemyPrefabPool.Length && returnTransform == null)
            {
                if (!enemyPrefabPool[c].gameObject.activeInHierarchy)
                {
                    returnTransform = enemyPrefabPool[c];
                    enemyPrefabPool[c].gameObject.SetActive(true);
                }
                c++;
            }

            return returnTransform;
        }
    }

    public Transform[] EnemiesInPlay
    {
        get
        {
            List<Transform> enemiesInPlay = new List<Transform>();
            foreach(Transform enemy in enemyPrefabPool)
            {
                if(enemy.gameObject.activeInHierarchy)
                {
                    enemiesInPlay.Add(enemy);
                }
            }
            return enemiesInPlay.ToArray();            
        }
    }

    public int numPlayerProjectilesInScene;
    public Transform projectilePrefab;
    protected Transform[] projectilePool = new Transform[0];
     
    public void InitializeProjectiles()
    {
        if (projectilePool.Length == 0)
        {
            projectilePool = new Transform[numPlayerProjectilesInScene];
            for (int c = 0; c < numPlayerProjectilesInScene; c++)
            {
                projectilePool[c] = Instantiate(projectilePrefab);
                projectilePool[c].gameObject.SetActive(false);
            }
        }
    }

    public Transform Projectile
    {
        get
        {
            Transform returnTransform = null;
            int c = 0;
            while (c < projectilePool.Length && returnTransform == null)
            {
                if (!projectilePool[c].gameObject.activeInHierarchy)
                {
                    returnTransform = projectilePool[c];
                    projectilePool[c].gameObject.SetActive(true);
                }
                c++;
            }
            return returnTransform;
        }
    }

}
