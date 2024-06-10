using UnityEngine;

[RequireComponent(typeof(ForceAdder))]
public class FlipFlap : MonoBehaviour
{
    private ForceAdder _forceAdder;

    private void Awake()
    {
        _forceAdder = GetComponent<ForceAdder>();
    }

    public void Swing()
    {
        _forceAdder.AddForce();
    }
}