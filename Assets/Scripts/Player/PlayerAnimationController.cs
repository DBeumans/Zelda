using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : InputBehaviour {


    Animator _animator;

    bool _isWalking=false;
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
        float _vertical = _player_Movement.GetAxisZ;
        float _horizontal = _player_Movement.GetAxisX;

        _isAttacking = _player_Attack.attack;

        if (Mathf.Abs(_vertical) == 0 && Mathf.Abs(_horizontal) == 0)
        {
            _isWalking = false;
            _isIdle = true;
        }

        else
        {
            _isWalking = true;
            _isIdle = false;
            _isAttacking = false;
        }



        _animator.SetBool("Attack", _isAttacking);

        _animator.SetFloat("Vertical", _vertical);
        _animator.SetFloat("Horizontal", _horizontal);
        _animator.SetBool("isWalking", _isWalking);
        _animator.SetBool("isIdle", _isIdle);

        
        
    }

    public void ChangeAttackVariable()
    {
        print("FALSe");
        _player_Attack.attack = false;
        _player_Attack.CanAttack = true;

    }
}
