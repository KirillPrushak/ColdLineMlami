using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private float _maxSpeed = 2f;
        [SerializeField] private float _moveSpeed = 5f;
        [SerializeField] private float _stoppingSpeed = 40f;
        private Rigidbody _rigidbody;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move(Vector2 direction)
        {
            var force = new Vector3(direction.x, 0, direction.y) * _moveSpeed;

            if (force.magnitude > 0f)
            {
                if (_rigidbody.velocity.magnitude < _maxSpeed)
                {
                    _rigidbody.AddForce(force);
                }
                _rigidbody.AddForce(force);
            }
            else
            {
                //Плавная остановка
                _rigidbody.velocity *= _stoppingSpeed * Time.fixedDeltaTime;
            }
        }
    }
}