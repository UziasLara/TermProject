﻿using UnityEngine;
using System.Collections;

public class FPSCamera : MonoBehaviour {

	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensitivity = 5f;
	public float smoothing = 2f;

	GameObject player;

	// Use this for initialization
	void Start () {
		player = this.transform.parent.gameObject;
	}

	// Update is called once per frame
	void Update () {
		var md = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

		md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing);
		smoothV.y = Mathf.Lerp (smoothV.y, md.y, 1f / smoothing);
		mouseLook += smoothV;
		mouseLook.y = Mathf.Clamp (mouseLook.y,-90f,90f);





		transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
		player.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, player.transform.up);
	}
}
