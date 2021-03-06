﻿using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour {

    [SerializeField]
    float _movementSpeed = 20f;
    [SerializeField]
    Transform _target;

    Vector3 _angles;

    public float GetMovementSpeed { get { return _movementSpeed; } set { _movementSpeed = value; } }
    public float GetAxisZ { get { return _z; } }
    public float GetAxisX { get { return _x; } }

    void Update() {
        KeysCheck();
        Vector3 _direction = new Vector3(_x, 0f, _z);
        if (_direction.magnitude > 1) {
            _direction.Normalize();
        }
        transform.Translate(_direction * _movementSpeed * Time.deltaTime);


        transform.LookAt(_target);
        _angles = transform.eulerAngles;
        transform.eulerAngles = new Vector3(0, _angles.y, _angles.z);
    }


}
