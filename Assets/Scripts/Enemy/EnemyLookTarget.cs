using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookTarget : MonoBehaviour {

	private GameObject _target;
	private Vector3 _targetPos;
	private Vector3 _angles;

	void Start() {
		_target = GameObject.FindWithTag("EnemyLookAt");
	}

	void Update() {
		_targetPos = _target.transform.position;
		transform.LookAt(_targetPos);
		_angles = transform.eulerAngles;
		transform.eulerAngles = new Vector3(0, _angles.y, _angles.z);
	}
}
