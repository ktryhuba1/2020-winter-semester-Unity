using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 1;

    protected bool leftReached = false;
    protected bool rightReached = false;
    protected bool alive = true;

    void Update()
    {
       if(alive)
        {
            float xDirection = Input.GetAxis("Horizontal");
            Vector3 translation = new Vector3(speed * xDirection, 0, 0);

            if (rightReached == false && translation.x > 0)
            {
                transform.Translate(translation * Time.deltaTime, Space.Self);
                leftReached = false;
            }
            //moving 
            if (leftReached == false && translation.x < 0)
            {
                transform.Translate(translation * Time.deltaTime, Space.Self);
                rightReached = false;
            }
        }
       else
        {
           
        }
        
    }
    private void OnTriggerEnter2D(Collider2D theThingIJustBumpedInto)
    {
        if (theThingIJustBumpedInto.gameObject.name.Equals("Wall (1)")) // .tag.Equals("Wall"))
        {
            rightReached = true;
        }
        if (theThingIJustBumpedInto.gameObject.name.Equals("Wall"))
        {
            leftReached = true;
        }
        if(theThingIJustBumpedInto.gameObject.tag.Equals("Bullet"))
        {
            alive = false;
            Destroy(theThingIJustBumpedInto.gameObject);
            gameObject.GetComponent<SpriteRenderer>().Equals(false);

        }
    }
}
