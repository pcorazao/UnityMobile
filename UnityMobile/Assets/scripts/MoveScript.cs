using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
			if (Input.touchCount == 1) {
			transform.Translate(Input.touches[0].deltaPosition.x * .25f,
			                    Input.touches[0].deltaPosition.y * .25f,
			                    0);
			}
	}
}
