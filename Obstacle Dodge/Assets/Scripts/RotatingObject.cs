using UnityEngine;
using UnityEngine.UIElements;

public class RotatingObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float objectRptationSpeed = 2f;
    void objectRotation()
    {
        float xAngle = 0f;
        float yAngle = 1f;
        float zAngle = 0f;
        transform.Rotate(xAngle,yAngle * objectRptationSpeed,zAngle);
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
