using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {


    public GameObject lobster;
    Rigidbody rb;
    public Vector3 down;
    public Vector3 up;
    public Vector3 left;
    public Vector3 right;
    public float maxSpeed = 30.0f;
    public Vector3 Max = new Vector3(5.0f, 20.0f, 0.0f);
    public Vector3 Min = new Vector3(-5.0f, -20.0f, 0.0f);
	// Use this for initialization
	void Start () {
        lobster = GameObject.Find("LittleLobster");
        rb = GetComponent<Rigidbody>();
        down = new Vector3(0.0f, -8.0f, 0.0f);
        up = new Vector3(0.0f, 10.0f, 0.0f);
        left = new Vector3(-0.5f, 0.0f, 0.0f);
        right = new Vector3(0.5f, 0.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vel = rb.velocity;

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            rb.AddForce(down, ForceMode.Impulse);
        } else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(up, ForceMode.Impulse);
     

        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(left, ForceMode.Impulse);
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(right, ForceMode.Impulse);
        }
        if (vel.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.Min(rb.velocity, Max);
            rb.velocity = Vector3.Max(rb.velocity, Min);

        }

	}


}
