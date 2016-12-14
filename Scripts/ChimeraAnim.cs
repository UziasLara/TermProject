using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimeraAnim : MonoBehaviour {
	
	private Animator anim;
	private float inputH;
	private float inputV;
	private bool run;


	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		run = false;
	}
	
	// Update is called once per frame
	void Update () {
		ChimeraAnimator ();
	}

	void ChimeraAnimator() {

		inputH = Input.GetAxis ("Horizontal");
		inputV = Input.GetAxis ("Vertical");
		anim.SetFloat ("inputH", inputH);
		anim.SetFloat ("inputV", inputV);
		//anim.SetBool ("run",run);


		if (Input.GetKey (KeyCode.LeftShift)) {
			anim.SetBool ("run",true);
			
		} else {
			anim.SetBool ("run",false);
		}

		if(Input.GetKey (KeyCode.Space)) {
			anim.SetBool ("jump", true);

		}
		else {
			
			anim.SetBool ("jump",false);
		}


		

	}
}
