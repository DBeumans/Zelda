using UnityEngine;

public class Shoot_Movement : MonoBehaviour {
	private GameObject _enemy;
	private GameObject _player;
	private Vector3 _target;

    private Player_Atteck _playerAtteck;
    private Enemy_Atteck _enemyAtteck;
	
	void Start() 
    {
		_enemy = GameObject.FindWithTag("Enemy");
		_player = GameObject.FindWithTag("Player");
		_target = _player.transform.position;
        _playerAtteck = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Atteck>();
        _enemyAtteck = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy_Atteck>();
	}
	void Update()
    {
        transform.LookAt(_target);
        transform.position += GetForward() / 10;
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") {
            if (_playerAtteck.atteck) {
                _target = _enemy.transform.position;
            } else {
                Destroy(this.gameObject);
            }
        }
        if (other.tag == "Enemy") {
            if (_enemyAtteck.atteck) {
                _target = _player.transform.position;
            } else {
                Destroy(this.gameObject);
            }
        }
    }

    private Vector3 GetForward()
    {
        return transform.forward;
    }
}
