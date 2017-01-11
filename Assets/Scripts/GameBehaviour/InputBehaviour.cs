using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    protected float _x;
    protected float _z;

    protected bool _space;

    protected KeyCode _keySpace = KeyCode.Space;

    protected void KeysCheck()
    {
        _x = Input.GetAxis("Horizontal");
        _z = Input.GetAxis("Vertical");

        _space = Input.GetKey(_keySpace);
    }
}
