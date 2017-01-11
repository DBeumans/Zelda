using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour {

    [SerializeField]
    float _movementSpeed = 20f;
    void Update() {
        KeysCheck();
        Vector3 direction = new Vector3(_x, 0f, _z);

        if (direction.magnitude > 1) {
            direction.Normalize();
        }
        transform.Translate(direction * _movementSpeed * Time.deltaTime);

        if (_space)
        {
            // jump logic here.
        }
        
    }
}
