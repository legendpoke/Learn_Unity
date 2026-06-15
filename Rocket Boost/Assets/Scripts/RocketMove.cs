using UnityEngine;
using UnityEngine.InputSystem;

public class RocketMove : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    float xValue = 0f;
    float yValue = 0f;
    float zValue = 0f;
    private void OnEnable()
    {
        thrust.Enable();
    }

    void RocketUp()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space is pressed");
            float IncYvalue = yValue + 1f;
            transform.Translate(xValue,IncYvalue,zValue);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D is pressed");
            float IncXvalue = xValue + 1f;
            transform.Translate(IncXvalue,yValue,zValue);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W is pressed");
            float IncZvalue = zValue + 1f;
            transform.Translate(xValue, yValue, IncZvalue);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (thrust.IsPressed())
        {
            Debug.Log("Space Bar is pressed");
        }
        RocketUp();
    }
}
