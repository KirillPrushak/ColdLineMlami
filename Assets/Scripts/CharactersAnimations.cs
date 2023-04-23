using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharactersAnimations : MonoBehaviour
    {
        private Animator _animator;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            var speed = _rigidbody.velocity;
            // повернуть в сторону взгляда персонажа
            speed = Quaternion.Inverse(transform.rotation) * speed;
            
            _animator.SetFloat("ForwardSpeed", speed.z);
            _animator.SetFloat("RightSpeed", speed.x);

            bool IsMoving = speed.magnitude > 0.1f;
            _animator.SetBool("IsMoving", IsMoving );
        }
    }
}