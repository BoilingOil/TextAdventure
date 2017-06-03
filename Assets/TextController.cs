using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	// Use this for initialization
	void Start () {
		text.text = "Hello World!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			text.text = "Space key pressed";
		} else if (Input.GetKey(KeyCode.UpArrow)) {
			text.text = "Get On Up!";
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			text.text = "The Enemy's Gate is DOWN!!";
		}
	}
}
