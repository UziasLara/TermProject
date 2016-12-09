using UnityEngine;
using System.Collections;

public class LakeSoundTrigger : MonoBehaviour {


	public AudioClip enterLake;
	public AudioSource Lake;
	private AudioSource Background;



	// Use this for initialization
	void Start () {

		Lake = GetComponent<AudioSource> ();
		Background = GameObject.Find ("Background").GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter () {
		if (Background.isPlaying) {
			Background.enabled = false;
			Lake.enabled = true;
			Lake.Play ();
		}
		
	}

	void OnTriggerExit () {
		if(Background.enabled ==false) {
			Background.enabled = true;
			Lake.enabled = false;
			Background.Play ();
		}
	}




}
