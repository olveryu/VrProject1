using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour {
	
	public SteamVR_TrackedObject hmd;
	public SteamVR_TrackedObject leftController;
	public SteamVR_TrackedObject rightController;
	public Transform head;
	public NewHandController leftHand;
	public NewHandController rightHand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		copyTransform (hmd.transform, head);
		copyTransform (leftController.transform, leftHand.transform);
		copyTransform (rightController.transform, rightHand.transform);

		handleControllerInputs ();
	}

	private void copyTransform(Transform from, Transform to)
	{
		to.position = from.position;
		to.rotation = from.rotation;
	}

	private void handleControllerInputs()
	{
		int leftIndex = (int)leftController.index;
		int rightIndex = (int)rightController.index;

		leftHand.controllerVelocity = getControllerVelocity (leftIndex);
		rightHand.controllerVelocity = getControllerVelocity (rightIndex);
		leftHand.controllerAngularVelocity = getControllerAngularVelocity (leftIndex);
		rightHand.controllerAngularVelocity = getControllerAngularVelocity (rightIndex);

		float leftTrigger = getTrigger (leftIndex);
		float rightTrigger = getTrigger (rightIndex);

		leftHand.squeeze (leftTrigger);
		rightHand.squeeze (rightTrigger);

	}

	private float getTrigger(int controllerIndex)
	{
		return controllerIndex >= 0 ? SteamVR_Controller.Input (controllerIndex).GetAxis (Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).magnitude : 0.0f;

	}

	private Vector3 getControllerVelocity(int controllerIndex)
	{
		return controllerIndex >= 0 ? SteamVR_Controller.Input (controllerIndex).velocity : Vector3.zero;
	}

	private Vector3 getControllerAngularVelocity(int controllerIndex)
	{
		return controllerIndex >= 0 ? SteamVR_Controller.Input (controllerIndex).angularVelocity : Vector3.zero;
	}
}

