using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    private Transform _componentTransform;
    private float horizontal;
    private float vertical;
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
        _componentTransform = GetComponent<Transform>();

    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
      
            _componentRigidbody2D.velocity = new Vector2( horizontal, vertical);
        
        
    }
}

