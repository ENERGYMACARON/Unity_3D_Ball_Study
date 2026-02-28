using UnityEngine;
using UnityEngine.InputSystem;

public class Ground : MonoBehaviour
{
    private float moveInput;
    private Vector2 mousePosition;
    
    public void OnRotate(InputValue value)
    {
        moveInput = value.Get<float>();
    }

    void OnClick(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("클릭함");
        }
    }

    void OnMousePos(InputValue value)
    {
        mousePosition = value.Get<Vector2>();
        Debug.Log($"마우스 위치: {mousePosition}");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.localEulerAngles.z;
        zRotation -= moveInput * 100f * Time.deltaTime;
        // zRotation = zRotation - Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10,0,zRotation);
    }
}
