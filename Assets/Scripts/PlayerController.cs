using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Transform head;
	public HandController leftHand;
	public HandController rightHand;

	public Transform hmd;
	public Transform leftController;
	public Transform rightController;

	public Rigidbody leftHeldObject;
	public Rigidbody rightHeldObject;

	float saveMaxLeft;
	float saveMaxRight;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate(){
		head.rotation = hmd.rotation;
		head.position = hmd.position;
		leftHand.transform.position = leftController.position;
		rightHand.transform.position = rightController.position;
		leftHand.transform.rotation = leftController.rotation;
		rightHand.transform.rotation = rightController.rotation;

		int leftIndex = (int)leftController.GetComponent<SteamVR_TrackedObject> ().index;
		int rightIndex = (int)rightController.GetComponent<SteamVR_TrackedObject> ().index;


		//left hand control
		if (leftIndex >= 0) {
			float leftTrigger = SteamVR_Controller.Input (leftIndex).GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).magnitude;
			//left hand hold
			if (leftHand.intersected != null && leftTrigger > .2f) {
				leftHeldObject = leftHand.intersected;
				//saveMaxLeft = leftHand.intersected.maxAngularVelocity;
				//leftHand.intersected.maxAngularVelocity = Mathf.Infinity;
			}
			//left hand release
			if (leftHeldObject != null && leftTrigger <= .2f) {
				leftHeldObject.velocity = SteamVR_Controller.Input (leftIndex).velocity * 9;
				//leftHeldObject.angularVelocity = SteamVR_Controller.Input (leftIndex).angularVelocity;
				//leftHeldObject.maxAngularVelocity = saveMaxLeft;
				leftHeldObject = null;
			}
			if (leftHeldObject != null) {
				leftHeldObject.velocity = (leftHand.transform.position - leftHeldObject.position) / Time.deltaTime;

				float angle;
				Vector3 axis;
				Quaternion q = leftHand.transform.rotation * Quaternion.Inverse(leftHeldObject.rotation);
				q.ToAngleAxis (out angle, out axis);
				//leftHeldObject.angularVelocity = axis * angle * Mathf.Deg2Rad / Time.deltaTime;

			}

		}

		//right hand control
		if (rightIndex >= 0) {
			float rightTrigger = SteamVR_Controller.Input (rightIndex).GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).magnitude;
			//right hand hold
			if (rightHand.intersected != null && rightTrigger > .2f) {
				rightHeldObject = rightHand.intersected;
				//saveMaxRight = rightHand.intersected.maxAngularVelocity;
				//rightHand.intersected.maxAngularVelocity = Mathf.Infinity;
			}
			//right hand release
			if (rightHeldObject != null && rightTrigger <= .2f) {
				rightHeldObject.velocity = SteamVR_Controller.Input (rightIndex).velocity * 9;
				//rightHeldObject.angularVelocity = SteamVR_Controller.Input (rightIndex).angularVelocity;
				//rightHeldObject.maxAngularVelocity = saveMaxRight;
				rightHeldObject = null;

			}
			if (rightHeldObject != null) {
				rightHeldObject.velocity = (rightHand.transform.position - rightHeldObject.position) / Time.deltaTime;
				//rightHeldObject.velocity {rightHand.transform.rotation; rightHeldObject.rotation};
				//rightHeldObject.transform.Rotate(180, 0, 0);
				float angle;
				Vector3 axis;
				Quaternion q = rightHand.transform.rotation * (Quaternion.Inverse(rightHeldObject.rotation));
				q.ToAngleAxis (out angle, out axis);
				//rightHeldObject.angularVelocity =  axis * angle * Mathf.Deg2Rad / Time.deltaTime;
			}
		}
	}

}
