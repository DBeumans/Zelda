using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
    void FixedUpdate() {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0f, z);

        if (direction.magnitude > 1) {
            direction.Normalize();
        }
        transform.Translate(direction);
    }
}