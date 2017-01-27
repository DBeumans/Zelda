using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Atteck : MonoBehaviour {

	private bool _atteck = false;

	public bool atteck { get { return _atteck; } }
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.Space)) {
			_atteck = true;
		} else {
			_atteck = false;
		}
	}
}
