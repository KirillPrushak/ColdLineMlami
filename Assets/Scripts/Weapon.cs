using UnityEngine;

namespace DefaultNamespace.Ai
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private int Damage = 10;
        [SerializeField] private int Rpm = 5;
        [SerializeField] private int MagSize = 30;

        public void Shot()
        {
            Debug.Log("Shot!");
        }
    }
}