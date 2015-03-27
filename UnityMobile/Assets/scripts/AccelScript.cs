using UnityEngine;
using System.Collections;

public class AccelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//remember screen is pos twoards
		transform.Translate (Input.acceleration.x * Time.deltaTime, 0,
		                    -Input.acceleration.z * Time.deltaTime);
	}
}
