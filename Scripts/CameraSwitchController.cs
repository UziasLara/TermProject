using UnityEngine;
using System.Collections;

public class CameraSwitchController : MonoBehaviour {

	public Camera FPS;
	public Camera TPS;


	// Use this for initialization
	void Start () {
		FPS.enabled = true;
		TPS.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		SwitchCamera ();
	}

	private void SwitchCamera() {
		
		if(Input.GetKeyDown (KeyCode.JoystickButton6)) {
			FPS.enabled = !FPS.enabled;
			TPS.enabled = !FPS.enabled;
		}


	}
}
