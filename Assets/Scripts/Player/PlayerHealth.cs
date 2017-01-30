using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	private PlayerAttack _attack;

	[SerializeField]
	private int _lives = 5;
	private bool _gethited = false;

	public int lives { get { return _lives; } }

	void Start () {
		_attack = gameObject.GetComponent<PlayerAttack>();
	}

	void Update () {
		if (_gethited) {
			_gethited = false;
		}
		if (!_attack.attack && !_gethited) {
			_lives--;
			_gethited = true;
		}
		if (_lives >= 0) {
			print("Dead");
		}
	}
}
