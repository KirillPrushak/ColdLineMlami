using Ai;
using UnityEngine;

namespace DefaultNamespace.Ai
{
    public class AttackState : IState
    {
        private readonly StateMachine _stateMachine;
        private readonly DetectionTrigger _detectionTrigger;
        private readonly BotCaracterController _botCaracterController;
        private readonly Weapon _weapon;

        public AttackState(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;

            _botCaracterController = stateMachine.GetComponent<BotCaracterController>();
            _weapon = stateMachine.GetComponentInChildren<Weapon>();
            _detectionTrigger = _stateMachine.GetComponentInChildren<DetectionTrigger>();
        }
        
        public void Tick()
        {
            _botCaracterController.Stop();
            _weapon.Shot();
        }

        public IState GetNextState()
        {
            if (!_detectionTrigger.IsPlayerInTrigegr)
            {
                return _stateMachine.Chase;
            }
            return this;
        }
    }
}