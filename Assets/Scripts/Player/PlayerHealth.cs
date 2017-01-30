using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	private PlayerAttack _attack;

	[SerializeField]
	private int _lives = 5;
	private bool _gethited = false;

	public int lives { get { return _lives; } }

	void Start () {
		_attack = gameObject.GetComponent<PlayerAttack>();
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            if(!_attack.attack)
            {
                GetDamage(1);
            }
        }
    }
    void GetDamage(int damage)
    {
        _lives -= damage;
    }

    public void Death()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(0);
    }
}
