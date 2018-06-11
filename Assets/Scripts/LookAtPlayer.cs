using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

	public GameObject mTarget;

	float mSpeed = 1;

	const float EPSILON = 0.1f;

	// Use this for initialization
	void Start () {
		mTarget = GameObject.Find("Target");
        mTarget = GameObject.Find("/MixedRealityCameraParent/Target");
        mTarget = GameObject.Find("MixedRealityCameraParent/Target");
    }
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (mTarget.transform.position);

		if ((transform.position - mTarget.transform.position).magnitude > EPSILON) {

			transform.Translate(0.0f, 0.0f, mSpeed*Time.deltaTime);

		}
	}
}
