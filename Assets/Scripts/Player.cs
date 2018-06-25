using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Declaring variables
    public float moveSpeed;
    public float turnSpeed;
    private Transform tf;

    // Use this for initialization
    void Start () {
        // Acquiring component for movement
        tf = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        // if statement for up key controlled movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position = tf.position + (GetComponent<Transform>().up * moveSpeed * Time.deltaTime);
        }

        // if statement for right key controlled movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -turnSpeed);
        }

        // if statement for left key controlled movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, turnSpeed);

        }

        // if statement for down key controlled movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position = tf.position + (-GetComponent<Transform>().up * moveSpeed * Time.deltaTime);
        }
    }
}
