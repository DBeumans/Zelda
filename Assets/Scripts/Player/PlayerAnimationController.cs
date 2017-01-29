using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour {


    Animator _animator;

    Player_Movement _player_Movement;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _player_Movement = GetComponent<Player_Movement>();
    }

    private void Update()
    {
        float _vertical = _player_Movement.GetAxis;
        _animator.SetFloat("Vertical", _vertical);
    }
}
