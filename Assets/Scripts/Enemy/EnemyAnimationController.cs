using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour {

    Animator _animator;
    bool _isAttacking;
    bool _isHit;
    bool _isDeath;
    EnemyAttack _enemy_Attack;
    EnemyHealth _enemy_Health;
    Enemy_Movement _enemy_Movement;
    Player_Movement _player_Movement;
    Enemy_Shooting _enemy_Shooting;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _enemy_Attack = GetComponent<EnemyAttack>();
        _enemy_Health = GetComponent<EnemyHealth>();
        _enemy_Movement = GetComponent<Enemy_Movement>();
        _enemy_Shooting = GetComponent<Enemy_Shooting>();
        _player_Movement = GameObject.FindObjectOfType<Player_Movement>();
    }

    void Update()
    {
        _isAttacking = _enemy_Attack.attackAnimation;
        _isHit = _enemy_Attack.hitAnimation;

        if (_enemy_Health.lives <= 0)
        {
            _enemy_Shooting.enabled = false;
            _player_Movement.GetMovementSpeed = 0;
            _enemy_Movement.GetMaxSpeed = 0;
            _isDeath = true;
        }
            

        _animator.SetBool("Death", _isDeath);

        _animator.SetBool("Hit", _isHit);
        _animator.SetBool("Attack", _isAttacking);
    }
}

