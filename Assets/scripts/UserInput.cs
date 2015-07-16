using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {
	public float moveSpeed = 5.0f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)){
			transform.position += new Vector3(1f,0f,0f) * Time.deltaTime * moveSpeed;
		}
		if (Input.GetKey(KeyCode.S)){
			transform.position += new Vector3(-1f,0f,0f) * Time.deltaTime * moveSpeed;
		}
		if (Input.GetKey(KeyCode.A)){
			transform.position += new Vector3(0f,0f,1f) * Time.deltaTime * moveSpeed;
		}
		if (Input.GetKey(KeyCode.D)){
			transform.position += new Vector3(0f,0f,-1f) * Time.deltaTime * moveSpeed;
		}
	}
}
