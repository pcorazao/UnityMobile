using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		Touch myTouch = Input.GetTouch (0);
//
//		myTouch.deltaTime
//
//		//myTouch.deltaPosition position moved since last position
//		//myTouch.deltaTime between
//		//fingerId is the index of the next finger
//		//phase - begin, moving, stationary, ended, canceled
//		//position - position on the screen
//		//tapCount - how many times it been touched.


	}

	void OnGUI()
	{
		foreach (Touch touch in Input.touches) {
			string message = "";
			message += "ID: " + touch.fingerId + "\n";
			message += "Phase: " + touch.phase.ToString() + "\n";
			message += "TapCount: " + touch.tapCount + "\n";
			message += "Pos X: " + touch.position.x + "\n";
			message += "Pos Y: " + touch.position.y + "\n";

			int num = touch.fingerId;
			GUI.Label(new Rect(0+130*num,0,120,100),message);
		}
	}
}
