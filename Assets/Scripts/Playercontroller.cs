using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Playercontroller : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _moveSpeed;

    private void Start()
{
    _rigidbody = GetComponent<Rigidbody>();
    _joystick = FindObjectOfType<FixedJoystick>();
}

    private void FixedUpdate()
{
    Vector3 moveDirection = new Vector3(_joystick.Horizontal, 0f, _joystick.Vertical).normalized;

    _rigidbody.velocity = moveDirection * _moveSpeed;

    if (moveDirection != Vector3.zero)
    {
        Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, 0.1f);
    }
}

}
