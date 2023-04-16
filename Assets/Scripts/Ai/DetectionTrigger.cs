using System;
using UnityEngine;

namespace Ai
{
    public class DetectionTrigger : MonoBehaviour
    {
        [SerializeField] private string _playerTag = "Player";
        
        public bool IsPlayerInTrigegr { get; private set; }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                IsPlayerInTrigegr = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                IsPlayerInTrigegr = false;
            }
        }
    }
}