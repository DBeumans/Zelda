using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour {

    Animator _animator;
    bool _isAttacking;
    bool _isHit;
    EnemyAttack _enemy_Attack;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _enemy_Attack = GetComponent<EnemyAttack>();
    }

    void Update()
    {
        _isAttacking = _enemy_Attack.AttackAnimation;
        _isHit = _enemy_Attack.HitAnimation;
        _animator.SetBool("Hit", _isHit);
        _animator.SetBool("Attack", _isAttacking);
    }
}

