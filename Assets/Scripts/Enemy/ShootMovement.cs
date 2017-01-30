using UnityEngine;

public class ShootMovement : MonoBehaviour {
	private GameObject _enemy;
	private GameObject _player;
	private Vector3 _target;

    private PlayerAttack _playerattack;
    private EnemyAttack _enemyattack;
    private Enemy_Shooting _enemyShooting;
    private bool _going = true;

    public bool GetTarget { get { return _going; } }
	
	void Start() 
    {
		_enemy = GameObject.FindWithTag("Enemy");
		_player = GameObject.FindWithTag("Player");
		_target = _player.transform.position;
        _playerattack = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttack>();
        _enemyattack = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttack>();
        _enemyShooting = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy_Shooting>();
	}
	void FixedUpdate()
    {
        if (_going) {
            _target = _player.transform.position;
            this.gameObject.layer = LayerMask.NameToLayer("IgnoreEnemyCollision");
        } else {
            _target = _enemy.transform.position;
            this.gameObject.layer = LayerMask.NameToLayer("Enemy");
        }

        transform.LookAt(_target);
        transform.position += GetForward() / 10;
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") {
            if (_playerattack.attack) {
                _target = _enemy.transform.position;
                _going = false;
            } else {
                _enemyShooting.SetBulletsInSceneList.RemoveAt(0);
                Destroy(this.gameObject);
            }
        } else if (other.tag == "Enemy") {
            if (_enemyattack.attack) {
                _target = _player.transform.position;
                _going = true;
            } else {
                _enemyShooting.SetBulletsInSceneList.RemoveAt(0);
                Destroy(this.gameObject);
            }
        } else {
            _enemyShooting.SetBulletsInSceneList.RemoveAt(0);
            Destroy(this.gameObject);
        }
    }

    private Vector3 GetForward()
    {
        return transform.forward;
    }
}
