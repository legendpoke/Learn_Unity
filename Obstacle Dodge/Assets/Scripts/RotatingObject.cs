using UnityEngine;
using UnityEngine.UIElements;

public class RotatingObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float objectRptationSpeed = 1.5f;
    void objectRotation()
    {
        float xAngle = 0f;
        float yAngle = 0f;
        float zAngle = 1f;
        transform.Rotate(xAngle, yAngle,zAngle * objectRptationSpeed);
    } 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectRotation();
    }
}
