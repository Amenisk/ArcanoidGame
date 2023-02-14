using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private Transform _left;
    [SerializeField] private Transform _right;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        var target = transform.position;
        target.x += horizontalInput;
        target.x = Mathf.Clamp(target.x, _left.position.x, _right.position.x);
        transform.position = Vector3.MoveTowards(transform.position, target, _movementSpeed);
    }
}
