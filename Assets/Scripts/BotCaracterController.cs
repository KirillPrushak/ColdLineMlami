using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
//using Vector2 = System.Numerics.Vector2;

namespace DefaultNamespace
{
    public class BotCaracterController : MonoBehaviour, IMoveController
    {
        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        public void Move(Vector2 targetPosition)
        {
            var destination = new Vector3(targetPosition.x, transform.position.y, targetPosition.y);

            _navMeshAgent.destination = destination;
        }

        public void Stop()
        {
            _navMeshAgent.isStopped = true;
        }
    }
}