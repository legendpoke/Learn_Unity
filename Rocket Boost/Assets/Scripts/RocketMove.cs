using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RocketMove : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction Rotation;
    float rocketRotationSpeed = 20f;
    private float thrustStrength = 1000f; 
    Rigidbody rocketRigidbody;
    private void Start()
    {
        rocketRigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        thrust.Enable();
        Rotation.Enable();
    }

    private void ThrustProcess()
    {
        if (thrust.IsPressed())
        {
            rocketRigidbody.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
        }
    }

    private void RotationProcess()
    {
        float InputRotation = Rotation.ReadValue<float>();
        Debug.Log("The value is rotated : " + InputRotation);

        if(InputRotation > 0)
        {
            transform.Rotate(Vector3.forward * rocketRotationSpeed * Time.fixedDeltaTime);
        }

        else if (InputRotation < 0)
        {
            transform.Rotate(Vector3.back * rocketRotationSpeed * Time.fixedDeltaTime);
        }
    }

    private void FixedUpdate()
    {
        ThrustProcess();
        RotationProcess();
    }
}
