using UnityEngine;
using System.Collections;

public class FPSCamera : MonoBehaviour {

	public float mouseSense = 10.0f;


	private Camera FPS;
	private CharacterController cc;
	private GameObject player;


	// Use this for initialization
	void Start () {
		//player = this.transform.parent.gameObject;
		cc = GetComponent <CharacterController> ();
		FPS = GameObject.Find ("FPSCamera").GetComponent <Camera> ();
	}




	// Update is called once per frame
	void Update () {
		//Rotation
		float rotX = Input.GetAxis ("Right X") * mouseSense;

		rotX = Mathf.Clamp (rotX, -50,50);
		FPS.transform.Rotate (0,rotX,0);

			


	}
}
