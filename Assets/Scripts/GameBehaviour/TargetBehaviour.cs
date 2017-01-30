using UnityEngine;
using System.Collections;

public class TargetBehaviour : MonoBehaviour {
    [SerializeField]
	private GameObject _camera;
	private Vector3 _look;
	private float _zAngle;

	void Update() {
		transform.LookAt(_camera.transform);
		_look = transform.eulerAngles;
		transform.eulerAngles = new Vector3(_look.x,_look.y,_zAngle);
		_zAngle++;
	}
}