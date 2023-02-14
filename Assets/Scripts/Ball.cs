using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _impulse;
    private Rigidbody2D _body2D;
    private bool _isGrounded = true;

    private void Awake()
    {
        _body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && _isGrounded)
        {
            transform.SetParent(null);
            _body2D.AddForce(new Vector2(Random.Range(-800, 800), _impulse));
            _isGrounded = !_isGrounded;
        }   
    }
}
