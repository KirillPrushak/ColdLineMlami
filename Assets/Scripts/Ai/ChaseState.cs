using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;
using IState = DefaultNamespace.Ai.IState;
using StateMachine = DefaultNamespace.Ai.StateMachine;

namespace Ai
{
    public class ChaseState : IState
    {
        private readonly IMoveController _moveController;
        private readonly DetectionTrigger _detectionTrigger;
        private readonly StateMachine _stateMachine;
        private readonly Transform _transform;

        public ChaseState(StateMachine stateMachine)
        {
            _moveController = stateMachine.GetComponent<IMoveController>();
            
            _detectionTrigger = stateMachine.GetComponentInChildren<DetectionTrigger>();

            _transform = stateMachine.transform;
            
            _stateMachine = stateMachine;
        }
        
        public void Tick()
        {
            var playerPos = CharacterManager.Instance.Player.transform.position;
            
            var playerPos2 = new Vector2(playerPos.x, playerPos.z);
            _moveController.Move(playerPos2);
        }

        public IState GetNextState()
        {
            if (!_detectionTrigger.IsPlayerInTrigegr && !CanSeePlayer())
            {
                _moveController.Move(Vector2.zero);
                return _stateMachine.Idle;
            }

            if (_detectionTrigger.IsPlayerInTrigegr && CanSeePlayer())
            {
                return _stateMachine.Attack;
            }
            return this;
        }

        private bool CanSeePlayer()
        {
            var playerPos = CharacterManager.Instance.Player.transform.position;
            var direction = playerPos - _transform.position;
            if (Physics.Raycast(_transform.position, direction, out var hit))
            {
                if (hit.transform.CompareTag("Player"))
                {
                    return true;
                }
            }

            return false;
        }
    }
}