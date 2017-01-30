using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : InputBehaviour
{

	private bool _attack = false;

    bool _canAttack = true;

	public bool attack { get { return _attack; } set { _attack = value; } }
    public bool CanAttack { get { return _canAttack; } set { _canAttack = value; } }

    void Update()
    {
        KeysCheck();
        if (_space)
        {
            _attack = true;
            _canAttack = false;
        }
        else {
            _attack = false;
        }
    }


}
