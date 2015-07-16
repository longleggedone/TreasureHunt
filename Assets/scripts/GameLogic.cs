using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	string winText = "Find the Treasure";
	public Transform player;
	public Transform treasure;
	

	// Update is called once per frame
	void Update () {
		string textBuffer = winText;
		if(Input.GetKey(KeyCode.Space) && Vector3.Distance (player.position, treasure.position)<= 5){
			winText = "YOU WIN";
		}
		GetComponent<Text>().text = textBuffer;
	}
}
