using UnityEngine;
using System.Collections;

public class FootSteps : MonoBehaviour {


	public AudioSource footSteps;
	public AudioClip highStep;
	public AudioClip lowStep;

	private CharacterController player;

	// Use this for initialization
	void Start () {
		player = GetComponent <CharacterController> ();
		footSteps = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if (player.isGrounded && (player.velocity.magnitude > 2f && player.velocity.magnitude < 20f) && footSteps.isPlaying == false) {
			footSteps.volume = Random.Range (0.8f, 1);
			footSteps.pitch = Random.Range (0.8f, 1.1f);
			footSteps.Play ();

		} else if (player.isGrounded && player.velocity.magnitude > 20f && footSteps.isPlaying == false) {
			footSteps.volume = Random.Range (0.8f, 1);
			footSteps.pitch = Random.Range(2.0f,2.5f);
			footSteps.Play ();
		}
	}
}
