using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private float _speed = 2f;
    private bool _isMoving = true;
    public Slider speedSlider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _speed = speedSlider.value;

        if (_isMoving)
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }

        if(transform.position.x > 5.5f)
        {
            _isMoving = false;
        }
        else if (transform.position.x < -3.7f)
        {
            _isMoving = true;
        }


        
    }
}
