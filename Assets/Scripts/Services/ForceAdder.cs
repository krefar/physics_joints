using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ForceAdder : MonoBehaviour
{
    [SerializeField] private Vector3 _forceDirection;
    [SerializeField] private float _forceMultiple;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void AddForce()
    {
        _rigidbody.AddForce(_forceDirection * _forceMultiple, ForceMode.Force);
    }
}