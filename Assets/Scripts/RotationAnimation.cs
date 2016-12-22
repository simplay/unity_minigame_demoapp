using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnimation : MonoBehaviour {

	private Vector3 initialOrientation;
	private float rotationalAcceleration;

	void Start () {
		float totalDegrees = 360f;
		initialOrientation = new Vector3 (
			Random.value * totalDegrees, 
			Random.value * totalDegrees, 
			Random.value * totalDegrees
		);
		initialOrientation.Normalize ();
		rotationalAcceleration = 100;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the transform
		float speed = Time.deltaTime * rotationalAcceleration;
		transform.Rotate (initialOrientation * speed);
	}
}
