using UnityEngine;

public class Collison : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            ShootsCounter.Hits++;        
        }
    }
}
