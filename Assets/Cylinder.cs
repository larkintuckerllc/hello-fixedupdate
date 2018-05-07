using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour {
    static float SPEED = 5.0f;

	void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 velocity = new Vector3(SPEED, 0, 0);
        rb.velocity = velocity;
	}	
}
