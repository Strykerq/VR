using UnityEngine;
using UnityEngine.Events;

public class EventTarget : MonoBehaviour
{
    public UnityEvent TargetEvent;
  
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            TargetEvent.Invoke();
        }
        
    }
}
