using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperController : MonoBehaviour
{

    GameObject leftFlipper, rightFlipper;

    // Start is called before the first frame update
    void Start()
    {
        leftFlipper = GameObject.Find("LeftPaddle");
        rightFlipper = GameObject.Find("RightPaddle");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.LeftAlt))
        {
            leftFlipper.GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            leftFlipper.GetComponent<HingeJoint2D>().useMotor = false;
        }

        if (Input.GetKey(KeyCode.RightAlt))
        {
            rightFlipper.GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            rightFlipper.GetComponent<HingeJoint2D>().useMotor = false;
        }

    }
}
