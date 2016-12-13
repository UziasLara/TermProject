using UnityEngine;
using System.Collections;

public class LakeSplash : MonoBehaviour {

	//public AudioClip lakeSplash;

	//private AudioSource Background;
	private AudioSource Lake;


	// Use this for initialization
	void Start () {

		//Lake = GetComponent<AudioSource> ();
		//Background = GameObject.Find ("Background").GetComponent<AudioSource> ();
		Lake = GetComponent <AudioSource>();
		//Lake.enabled = false;
		//lakeSplash = GetComponent <AudioClip> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter () {
		if (Lake.enabled == false)
			Lake.enabled = true;
			Lake.Play ();

		//Lake.Play ();
	}

	void onTriggerExit() {
		Lake.enabled = false;
		
	}


		





}
