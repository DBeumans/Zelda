using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	private bool _attack = false;

	private IEnumerator coroutine;
	private float _attacking;
    private bool _attackAnimation;
    private bool _hitAnimation;
	public bool attack { get { return _attack; } }
    public bool attackAnimation { get { return _attackAnimation;} }
    public bool hitAnimation { get { return _hitAnimation; } }
	
	void Start() {
		coroutine = RandomNum(3.0f);
		StartCoroutine(coroutine);
	}

	void Update() {
		if (_attacking < Random.Range(0,10)) {
			_attack = true;
		} else {
			_attack = false; _attackAnimation = false; _hitAnimation = false;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Bullet" && _attack) {
            _attackAnimation = true;
		}
		if (other.tag == "Bullet" && !_attack) {
            _hitAnimation = true;
            print("enemy got hitted");
		}
	}

	private IEnumerator RandomNum(float waitTime) {
		while(true) {
			_attacking = Random.Range(0, 10);
			yield return new WaitForSeconds(3);
		}
	}
}
