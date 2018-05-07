using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    static float SPEED = 5.0f;
	
    /*
	void Update () {
        float deltaTime = Time.deltaTime;
        Vector3 position = transform.position;
        position.x += SPEED * deltaTime;
        transform.position = position;
	}
	*/

	void FixedUpdate()
	{
        float deltaTime = Time.deltaTime;
        Vector3 position = transform.position;
        position.x += SPEED * deltaTime;
        transform.position = position;
	}
}
