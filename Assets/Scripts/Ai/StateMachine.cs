﻿using System;
using Ai;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace DefaultNamespace.Ai
{
    public class StateMachine : MonoBehaviour
    {
        private IState _currentState;

        public ChaseState Chase { get; private set; }
        public IdleState Idle { get; private set; }
        
        public AttackState Attack { get; set; }

        private void Awake()
        {
            Chase = new ChaseState(this);
            Idle = new IdleState(this);
            Attack = new AttackState(this);
            
            _currentState = new IdleState(this);
        }

        private void FixedUpdate()
        {
            _currentState.Tick();
            _currentState = _currentState.GetNextState();
        }
    }
}