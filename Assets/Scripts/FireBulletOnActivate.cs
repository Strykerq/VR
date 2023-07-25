using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject Bullet;
    public Transform spawnPoint;   
    public float fireSpeed = 20f;

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }   
    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(Bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        ShootsCounter.Shots++;
        Destroy(spawnedBullet, 5);
    }

    
}
