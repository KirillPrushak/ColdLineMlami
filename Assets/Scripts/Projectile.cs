using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Projectile : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}