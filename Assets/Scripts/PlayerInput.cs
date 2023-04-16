using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerInput : MonoBehaviour
    {
        private CharacterController _controller;
        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            var forwardInput = 0f;
            var rightInput = 0f;
            
            if (Input.GetKey(KeyCode.W))
            {
                forwardInput = 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                forwardInput = -1f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                rightInput = -1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                rightInput = 1f;
            }
            
            _controller.Move(new Vector2(rightInput, forwardInput));
        }
    }
}