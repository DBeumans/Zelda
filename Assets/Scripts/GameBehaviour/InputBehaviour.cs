using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    protected float _x;
    protected float _z;

    protected bool _space;

    protected KeyCode _keySpace = KeyCode.Space;

    protected bool _mouseButton1;
    protected KeyCode _MouseButton1 = KeyCode.Mouse0;

    protected void KeysCheck()
    {
        _x = Input.GetAxis("Horizontal");
        _z = Input.GetAxis("Vertical");

        _space = Input.GetKey(_keySpace);

        _mouseButton1 = Input.GetKey(_MouseButton1);
           
    }
}
