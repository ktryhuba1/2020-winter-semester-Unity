using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawnPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(transform.position, 0.1f);
    }
}
