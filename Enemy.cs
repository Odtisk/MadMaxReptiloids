using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(Animator))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 100;

    private Rigidbody _rigidbody;
    private Animator _animator;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat("Speed", _speed);
        _rigidbody.AddForce(transform.forward * _speed);
    }
}
