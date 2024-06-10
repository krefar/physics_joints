using UnityEngine;

[RequireComponent(typeof(SpringJoint))]
public class SpringSwitcher : MonoBehaviour
{
    [SerializeField] Vector3 _firstAnchor;
    [SerializeField] float _firstDamper;

    [SerializeField] Vector3 _secondAnchor;
    [SerializeField] float _secondDamper;

    private SpringJoint _springJoint;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _springJoint = GetComponent<SpringJoint>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void SetFirstValue()
    {
        _springJoint.connectedAnchor = _firstAnchor;
        _springJoint.damper = _firstDamper;

        _rigidbody.WakeUp();
    }

    public void SetSecondValue()
    {
        _springJoint.connectedAnchor = _secondAnchor;
        _springJoint.damper = _secondDamper;

        _rigidbody.WakeUp();
    }
}