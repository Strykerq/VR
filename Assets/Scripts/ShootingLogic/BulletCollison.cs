using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace VRtIR.BulletCol
{
    public class BulletCollison : MonoBehaviour
    {        

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Target"))
            {
                
            }
        }
    }

   
}














       