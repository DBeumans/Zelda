using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour {

    [SerializeField]
    float _movementSpeed = 20f;
    [SerializeField]
    float _rotationSpeed = 2f;

    public float GetAxis { get { return _z; } }

    void Update() {
        KeysCheck();
        Vector3 _angle = new Vector3(0f, _x, 0f);
        Vector3 _direction = new Vector3(0f, 0f, _z);
        if (_direction.magnitude > 1) {
            _direction.Normalize();
        }
        transform.Translate(_direction * _movementSpeed * Time.deltaTime);

        this.transform.Rotate(_angle*_rotationSpeed);
    }


}
