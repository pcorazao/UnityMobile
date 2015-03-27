﻿using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
			if (Input.touchCount == 1) {
//			transform.Translate(Input.touches[0].deltaPosition.x * .25f,
//			                    Input.touches[0].deltaPosition.y * .25f,
//			                    0);

				Touch touch = Input.GetTouch(0);
				float x = -7.5f + 15 * touch.position.x / Screen.width;
				float y = -4.5f + 9 * touch.position.y / Screen.height;

			transform.position = new Vector3(x,y,0);

			}
	}
}
