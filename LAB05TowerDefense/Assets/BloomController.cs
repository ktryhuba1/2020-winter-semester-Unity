using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloomController : MonoBehaviour
{
    public float maxScale;
    public float speed;
    protected float increase, decrease;
    protected bool increasing;
    protected Vector3 startingScale;

    private void Start()
    {
        increase = 1 + (speed / 100);
        decrease = 1 - (speed / 100);
        increasing = true;

        startingScale = this.gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.gameObject.transform.localScale.x < maxScale && increasing)
        {
            this.gameObject.transform.localScale *= increase;
        }
        else
        {
            increasing = false;
        }

        if (!increasing)
        {
            StartCoroutine(Wait());  
        }
    }




    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Decrease();

    }

void Decrease()
    {
        this.gameObject.transform.localScale *= decrease;
        if(this.gameObject.transform.localScale.x < 1)
        {
            increasing = true;
            this.gameObject.transform.localScale = startingScale;
            this.gameObject.SetActive(false);
        }
    }





}
