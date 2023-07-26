using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using VRTir.UI;
using UnityEngine.Events;

namespace VRtir.BulletLogic
{
    public class FireBulletOnActivate : MonoBehaviour
    {
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _spawnPoint;
        private float _fireSpeed = 20f;
        public UnityEvent ShootsEvent;


        public void Start()
        {
            XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
            grabbable.activated.AddListener(FireBullet);
        }

        private void FireBullet(ActivateEventArgs arg)
        {
            GameObject spawnedBullet = Instantiate(_bullet);
            spawnedBullet.transform.position = _spawnPoint.position;
            spawnedBullet.GetComponent<Rigidbody>().velocity = _spawnPoint.forward * _fireSpeed;            
            Destroy(spawnedBullet, 5);
            ShootsEvent.Invoke();
          
        }
    }
}
