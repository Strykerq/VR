using UnityEngine;
using TMPro;
using VRtir.BulletLogic;
using UnityEngine.Events;

namespace VRTir.UI
{
    public class ShootsCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _shootsText;
        [SerializeField] private TextMeshProUGUI _hitsText;
        public FireBulletOnActivate BulletOnActivate;
        public EventTarget [] EventTargets;     
        private int _shots;
        private int _hits;
        
        public void Awake()
        {
            BulletOnActivate.ShootsEvent.AddListener(IncrementShot);
            foreach(EventTarget target in EventTargets)
            {
                target.TargetEvent.AddListener(IncrementHits);
            }                              
        }

        public void Start()
        {
            _shots = 0;
            _hits = 0;           
        }
        
        public void Reset()
        {
            _shots = 0;
            _hits = 0;
        }
        public void Update()
        {
            _shootsText.text = _shots.ToString();
            _hitsText.text = _hits.ToString() + "    /   ";          
        }

        public void IncrementShot()
        {
            _shots++;          
        }
        public void IncrementHits()
        {
            _hits++;
        }
    }
}
