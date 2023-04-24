using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Projectile : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);

            TryDealDamage(collision.gameObject);
        }

        private void TryDealDamage(GameObject other)
        {
            if (other.TryGetComponent<CharactersRagdoller>(out var ragdoller))
            {
                ragdoller.DoRagdoll();
            }
        }
    }
}