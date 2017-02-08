using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float moveSpeed = 0.0f;
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start() 
	{
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(Input.GetAxis("Vertical"),
			0,
			- Input.GetAxis("Horizontal")) * moveSpeed);
	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
	}

	void FixedUpdate () {
	//	rigidbody.AddForce(new Vector3(Input.GetAxis("Vertical"),
	//		0,
	//		- Input.GetAxis("Horizontal")) * moveSpeed);
	}
}
