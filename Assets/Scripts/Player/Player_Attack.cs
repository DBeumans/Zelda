using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour {

	private bool _attack = false;

	public bool attack { get { return _attack; } }
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.Space)) {
			_attack = true;
		} else {
			_attack = false;
		}
	}
}
