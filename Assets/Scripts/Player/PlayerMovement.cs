using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Player
{
    internal class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 1;
        private float _x, _y;
        private Animator _animator;
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            _x = Input.GetAxisRaw("Horizontal");
            _y = Input.GetAxisRaw("Vertical");

            //Brute Force Triggering
            if (_x == 1)
            {
                _animator.SetTrigger("Right");
                return;
            }
            if (_x == -1)
            {
                _animator.SetTrigger("Left");
                return;
            }
            if (_y == 1)
            {
                _animator.SetTrigger("Back");
                return;
            }
            if (_y == -1)
            {
                _animator.SetTrigger("Front");
                return;
            }

            _animator.ResetTrigger("Front");
            _animator.ResetTrigger("Back");
            _animator.ResetTrigger("Left");
            _animator.ResetTrigger("Right");
            _animator.SetTrigger("Idle");
        }

        private void FixedUpdate()
        {
            _rb.velocity = new Vector2(_x, _y).normalized * _speed;
        }
    }
}
