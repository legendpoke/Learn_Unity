using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class RocketMove : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction Rotation;
    float rocketRotationSpeed = 100f;
    private float thrustStrength = 1000f;
    [SerializeField] AudioClip thrustSound;

    Rigidbody rocketRigidbody;
    AudioSource audioSource;


    private void Start()
    {
        rocketRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
            if (!audioSource.isPlaying) // play the sound only one time 
            {
                audioSource.PlayOneShot(thrustSound);
            }
        }

        else
        {
            audioSource.Stop();
        }
    }

    private void ApplyRotation(float RotationSpeed)
    {
        rocketRigidbody.freezeRotation = true;
        transform.Rotate(Vector3.forward * RotationSpeed * Time.fixedDeltaTime);
        rocketRigidbody.freezeRotation = false;
    }

    private void RotationProcess()
    {
        float InputRotation = Rotation.ReadValue<float>();
        Debug.Log("The value is rotated : " + InputRotation);

        if(InputRotation > 0)
        {
            ApplyRotation(rocketRotationSpeed);
        }

        else if (InputRotation < 0)
        {
            ApplyRotation(-rocketRotationSpeed);//move the rocket in -ve rotation value 
        }
    }

    private void FixedUpdate()
    {
        ThrustProcess();
        RotationProcess();
    }

    private void Update()
    {
        
    }
}
