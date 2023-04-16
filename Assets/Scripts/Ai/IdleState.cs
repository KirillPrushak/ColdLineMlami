using Ai;
using DefaultNamespace.Ai;

namespace DefaultNamespace
{
    public class IdleState : IState
    {
        private readonly StateMachine _stateMachine;
        private DetectionTrigger _detectionTrigger;

        public IdleState(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;

            _detectionTrigger = _stateMachine.GetComponentInChildren<DetectionTrigger>();
        }

        public IState GetNextState()
        {
            if (_detectionTrigger.IsPlayerInTrigegr)
            {
                return _stateMachine.Chase;
            }
            
            return this;
        }
        
        public void Tick()
        {
            
        }
    }
}