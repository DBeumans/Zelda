using UnityEngine;

public class Shoot_Movement : MonoBehaviour {
	private GameObject _camera;
	private GameObject _player;
	private Vector3 _target;
	
	void Start() 
    {
		_camera = GameObject.FindWithTag("MainCamera");
		_player = GameObject.FindWithTag("Player");
		_target = _player.transform.position;
	}
	void Update()
    {
        transform.LookAt(_target);
        transform.position += GetForward() / 50;
    }

    private Vector3 GetForward()
    {
        return transform.forward;
    }
}
