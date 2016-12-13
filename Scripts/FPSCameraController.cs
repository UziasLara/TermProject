using UnityEngine;
using System.Collections;

public class FPSCameraController : MonoBehaviour {

	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensitivity = 20f;
	public float smoothing = 5f;

	GameObject player;

	// Use this for initialization
	void Start () {
		player = this.transform.parent.gameObject;
	}

	// Update is called once per frame
	void Update () {
		joystickLook ();
		mousePan ();
	}

	// Look with the mouse
	void mousePan () {
		var md = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

		md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing);
		smoothV.y = Mathf.Lerp (smoothV.y, md.y, 1f / smoothing);
		mouseLook += smoothV;
		mouseLook.y = Mathf.Clamp (mouseLook.y,-90f,90f);





		transform.localRotation = Quaternion.AngleAxis(mouseLook.y, Vector3.right);
		player.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, player.transform.up);
		
	}

	// Look with joystick
	void joystickLook() {
		var md = new Vector2 (Input.GetAxis("Right X"), Input.GetAxis("Right Y"));

		md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing);
		smoothV.y = Mathf.Lerp (smoothV.y, md.y, 1f / smoothing);
		mouseLook += smoothV;
		mouseLook.y = Mathf.Clamp (mouseLook.y,-90f,90f);





		transform.localRotation = Quaternion.AngleAxis(mouseLook.y, Vector3.right);
		player.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, player.transform.up);
		
	}
}
