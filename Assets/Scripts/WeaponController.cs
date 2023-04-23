using UnityEngine;

namespace DefaultNamespace
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] private Transform _shootingPoint;
        [SerializeField] private GameObject _projectilePrefab;
        [SerializeField] private float _bulletSpeed = 100f;

        public void Shot()
        {
            var bullet = Instantiate(_projectilePrefab, _shootingPoint.position, _shootingPoint.rotation);

            var bulletRigitbody = bullet.GetComponent<Rigidbody>();
            bulletRigitbody.AddForce(_shootingPoint.forward * _bulletSpeed);
        }
    }
}