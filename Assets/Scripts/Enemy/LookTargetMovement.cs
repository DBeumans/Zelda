using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTargetMovement : MonoBehaviour {

	private GameObject _enemy;

	private Vector3 _enemyPos;

	void Start () {
		_enemy = GameObject.FindWithTag("Enemy");
		_enemyPos = _enemy.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		_enemyPos = _enemy.transform.position;
		this.transform.position = new Vector3(this.transform.position.x, _enemyPos.y+.55f, this.transform.position.z);
	}
}
