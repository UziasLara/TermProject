using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//movement variables
	public float speed = 10f;
	public float jumpSpeed = 15.0f;
	public float gravity = 20.0f;
	public Vector3 moveDirection = Vector3.zero;


	public Text countText;
	public Text winText;
	//public AudioClip clip;


	//private Rigidbody rb;
	private int count;
	private float timer;
	private bool over = false;
	private CharacterController player;

	//private AnimatorControllerParameter jumpAnim;



	void Start () {
		
		Cursor.lockState = CursorLockMode.Locked;

		player = GetComponent<CharacterController> ();



		winText.text = "";
		count = 0;
		SetCountText ();



	}





	void Update() {
		playerMovement ();


	}

	void playerMovement() {

		

		if (player.isGrounded) {

			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;

			if (Input.GetButton ("Jump")) {
				
				moveDirection.y = jumpSpeed;
					
				
			} 
		}	
		moveDirection.y -= gravity * Time.deltaTime;
		player.Move (moveDirection * Time.deltaTime);


		if (over)
			return;
		

		// Sprint
		if (Input.GetKeyDown (KeyCode.JoystickButton8) | Input.GetKeyDown(KeyCode.LeftShift) | Input.GetButtonDown ("LeftClick") ) {
			speed = 30f;

		}

		if (Input.GetKeyUp (KeyCode.JoystickButton8) || Input.GetKeyUp(KeyCode.LeftShift) | Input.GetButtonUp ("LeftClick")) {
			speed = 10f;
		}

		if (Input.GetKeyDown ("escape"))
			Cursor.lockState = CursorLockMode.None;
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("Pick Up")) {


			other.gameObject.SetActive (false);
			//AudioSource.PlayClipAtPoint (clip, new Vector3(5,10,2));
			count++;

			SetCountText ();


		}
	}

	void SetCountText() {


		countText.text = "Count: " + count.ToString ();
		if (over) {
			winText.text = "You Win!";

		}
	}

	void endCount() {
		over = true;
		countText.color = Color.blue;
	}



}
