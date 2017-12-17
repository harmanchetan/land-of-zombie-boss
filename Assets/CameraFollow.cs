using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	[SerializeField]
	Transform mTarget;

	float kFollowSpeed = 7f;
	float stepOverThreshold = 0.20f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (mTarget != null)
		{
			Vector3 targetPosition = new Vector3( mTarget.transform.position.x, transform.position.y + 4, transform.position.z);
			Vector3 direction = targetPosition - transform.position;

			if (direction.magnitude > stepOverThreshold)
			{
				// If too far, translate at kFollowSpeed
				transform.Translate(direction.normalized * kFollowSpeed * Time.deltaTime);
			}
			else
			{
				// If close enough, just step over
				transform.position = targetPosition;
			}
		}
	}
}