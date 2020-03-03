using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperController : MonoBehaviour
{

    GameObject leftpaddle, rightpaddle;

    private void Start()
    {
        rightpaddle = GameObject.Find("flipperRight");
        leftpaddle = GameObject.Find("flipperLeft");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightAlt))
        {
            //this objects component called
            rightpaddle.GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            rightpaddle.GetComponent<HingeJoint2D>().useMotor = false;
        }

        if (Input.GetKey(KeyCode.LeftAlt))
        {
            //this objects component called
            leftpaddle.GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            leftpaddle.GetComponent<HingeJoint2D>().useMotor = false;
        }

    }




}
