using System.Collections;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(WaitThenFall());
    }

    IEnumerator WaitThenFall()
    {
        yield return new WaitForSeconds(1);

        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
