using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private FlipFlap _flipFlap;
    [SerializeField] private Catapult _catapult;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _flipFlap.Swing();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _catapult.Shoot();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _catapult.Reload();
        }
    }
}