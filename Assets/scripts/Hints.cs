using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hints : MonoBehaviour {

	public string hintText = "";
	public Transform player;
	
	// Update is called once per frame
	void Update () {
		string textBuffer = hintText;
		if (player.position.x < -150f){
			hintText = "Too far South";
		}else if(player.position.x > 150f){
			hintText = "Too far North";
		}else if(player.position.z < -150f){
			hintText = "Too far East";
		}else if(player.position.z > 150f){
			hintText = "Too far West";
		}else{
			hintText = "";
		}
		GetComponent<Text>().text = textBuffer;
	}
}
