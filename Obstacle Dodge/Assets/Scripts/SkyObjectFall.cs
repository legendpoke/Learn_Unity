using JetBrains.Annotations;
using System.Security.Cryptography;
using UnityEngine;

public class SkyObjectFall : MonoBehaviour
{
    private float fallTimeAfter = 3f;

    MeshRenderer mymeshRender;//MeshRenderer is a type and 
    //mymeshRender is a variable and this variable name can be anything and same as other components like rigidbody and other things
    Rigidbody myRigidbody;
    void objectVisible()
    {
        if (Time.time > fallTimeAfter) {
            mymeshRender.enabled = true;
        }
    }
    void objectFall()
    {
        if (Time.time > fallTimeAfter)
        {
            myRigidbody = GetComponent<Rigidbody>();
            myRigidbody.useGravity = true;//make the object fall after 3 seconds in the game 
            Debug.Log("Object fall!");//used to see in the console
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mymeshRender = GetComponent<MeshRenderer>();
        mymeshRender.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        objectVisible();
        objectFall();
    }
}
