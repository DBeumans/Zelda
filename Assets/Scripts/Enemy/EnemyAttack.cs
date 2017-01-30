using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	private bool _attack = false;

	private IEnumerator coroutine;
	private float _attacking;

	public bool attack { get { return _attack; } }
	
	void Start() {
		coroutine = RandomNum(3.0f);
		StartCoroutine(coroutine);
	}

	void Update() {
		if (_attacking < 5) {
			_attack = true;
		} else {
			_attack = false;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Bullet" && _attack) {
			print("attack");
		}
		if (other.tag == "Bullet" && !_attack) {
			print("is hited");
		}
	}

	private IEnumerator RandomNum(float waitTime) {
		while(true) {
			_attacking = Random.Range(0, 10);
			yield return new WaitForSeconds(3);
		}
	}
}
