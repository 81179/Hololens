using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorFollow : MonoBehaviour {

	public Transform mTarget;

	float mSpeed = 10.0f;
	Vector3 mLookDirection;

	const float EPSILON = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		mLookDirection = (mTarget.position - transform.position).normalized;

		if ((transform.position - mTarget.position).magnitude > EPSILON) {
			transform.Translate (mLookDirection * Time.deltaTime * mSpeed);

		}
	}
}
