using UnityEngine;
using System.Collections;

public class BossSound : MonoBehaviour {


	public AudioClip enterBoss;
	public AudioSource Boss;
	private AudioSource Background;



	// Use this for initialization
	void Start () {

		Boss = GetComponent<AudioSource> ();
		Background = GameObject.Find ("Background").GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter () {
		if (Background.isPlaying) {
			Background.enabled = false;
			Boss.enabled = true;
			Boss.Play ();
		}

	}

	void OnTriggerExit () {
		if(Background.enabled ==false) {
			Background.enabled = true;
			Boss.enabled = false;
			Background.Play ();
		}
	}




}
