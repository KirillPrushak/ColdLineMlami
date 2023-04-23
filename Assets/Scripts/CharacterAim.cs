using System;
using UnityEngine;

namespace DefaultNamespace
{
    public partial class CharacterAim : MonoBehaviour
    {
        public void LookAt(Vector3 targetPosition)
        {
            targetPosition.y = transform.position.y;

            transform.forward = targetPosition - transform.position;
        }
    }
}