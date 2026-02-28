using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    int count = 1;
    float startingPoint;
    bool shouldPrintOver20 = true;
    bool shouldPrintOver30;
    // SphereCollider myCollider;
    Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
        TestMethod();
        startingPoint = transform.position.z;

        myRigidbody = GetComponent<Rigidbody>();
        Debug.Log("중력 사용 여부: " + myRigidbody.useGravity);

        // myCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        // myCollider.radius = myCollider.radius + 0.01f;
        float distance;
        distance = transform.position.z - startingPoint;
        // Debug.Log(distance);
        // int localCount = 0;
        // Debug.Log("Update"+count);
        // count = count + 1;
        // Debug.Log(transform.position.z);
        if(distance>30)
        {
            if(shouldPrintOver30)
            {
                Debug.Log("Over 30:" + distance);
                shouldPrintOver30 = false;
            }
        } else if(distance > 20) 
        {
            if(shouldPrintOver20)
            {
                Debug.Log("Over 20:" + distance);
                shouldPrintOver20 = false;
            }
            
        }
    }

    void TestMethod()
    {
        Debug.Log("this is TestMethod");
    }

    void OnJump(InputValue value)
    {
        myRigidbody.AddForce(Vector3.up*5f, ForceMode.VelocityChange);
    }
}
