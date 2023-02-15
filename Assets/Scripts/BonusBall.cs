using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBall : MonoBehaviour
{
    [SerializeField] private float _impulse;
    private Rigidbody2D _body2D;
    private bool _isGrounded = true;

    private void Awake()
    {
        _body2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        transform.SetParent(null);
        _body2D.AddForce(new Vector2(Random.Range(-800, 800), _impulse));
        _isGrounded = !_isGrounded;
    }
}
