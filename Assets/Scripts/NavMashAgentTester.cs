using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

namespace DefaultNamespace
{
    public class NavMashAgentTester : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            _navMeshAgent.destination = _target.position;
        }
    }
}