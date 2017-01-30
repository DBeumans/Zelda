using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : InputBehaviour {


    Animator _animator;

    bool _isWalking = false;
    bool _isIdle = true;
    bool _isAttacking = false;

    Player_Movement _player_Movement;
    PlayerAttack _player_Attack;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _player_Movement = GetComponent<Player_Movement>();
        _player_Attack = GetComponent<PlayerAttack>();
    }

    private void Update()
    {
        float _vertical = _player_Movement.GetAxis;
        _isAttacking = _player_Attack.attack;

        if (_isAttacking)
        {
            _animator.SetTrigger("isAttacking");
            _player_Attack.CanAttack = false;
        }
            


        if (Mathf.Abs(_vertical) > .05f)
        {
            _isWalking = true;
            _isIdle = false;
        }
            

        if (Mathf.Abs(_vertical) < .05f)
        {
            _isIdle = true;
            _isWalking = false;
        }

        _animator.SetFloat("Vertical", _vertical);
        _animator.SetBool("isWalking", _isWalking);
        _animator.SetBool("isIdle", _isIdle);

        if(_animator.GetAnimatorTransitionInfo(1).IsName("Attack"))
        {

        }
       

    }
}
