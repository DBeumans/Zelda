using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	private EnemyAttack _attack;

	[SerializeField]
	private int _lives = 5;
	private bool _gethited = false;

	public int lives { get { return _lives; } }

	void Start () {
		_attack = gameObject.GetComponent<EnemyAttack>();
	}

	void Update () {
		if (_attack.hitAnimation && !_gethited) {
			_lives--;
			_gethited = true;
		}
		if (!_attack.hitAnimation && _gethited) {
			_gethited = false;
		}
	}
}
