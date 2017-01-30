using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour {

	private EnemyAttack _attack;

	[SerializeField]
	private int _lives = 5;
	private bool _gethited = false;

	public int lives { get { return _lives; } }

	void Start () {
		_attack = gameObject.GetComponent<EnemyAttack>();
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            if (_attack.hitAnimation && !_gethited)
                GetDamage(1);
        }
    }

    private void GetDamage(int damage)
    {
        _lives -= damage;
        print(_lives);
    }

    public void Death()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(0);
    }
}
