using UnityEngine;
using System.Collections;

public class TPSCameraController : MonoBehaviour {

	private const float Y_ANGLE_MIN = -15.0f;
	private const float Y_ANGLE_MAX = 4.0f;
	private const float X_ANGLE_MIN = -50.0f;
	private const float X_ANGLE_MAX = 50.0f;

	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;


	private float distance = 5.0f;
	//private float sideDistance = 10.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensitivityX = 4.0f;
	private float sensitivityY = 1.0f;
	private Transform follow; 
	private Vector3 targetPosition;




	private void Start() {
		//follow = GameObject.Find ("Player").transform;

		camTransform = transform;
		cam = GameObject.Find ("TPSCamera").GetComponent <Camera> ();

	}



	private void Update () {
		currentX += Input.GetAxis ("Mouse X") ;
		currentY += Input.GetAxis ("Mouse Y"); 

		currentX = Mathf.Clamp (currentX, X_ANGLE_MIN, X_ANGLE_MAX);
		currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}




	private void LateUpdate() {

		//targetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;


		Vector3 dir = new Vector3 (0, 0, -distance);
		//Quaternion rotation = Quaternion.Euler (0,currentX,-currentY);
		Quaternion rotation = Quaternion.Euler (-currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt (lookAt.position);
	}

}