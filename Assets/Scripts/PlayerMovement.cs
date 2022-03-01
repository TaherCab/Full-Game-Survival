using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speedPlayer = 3f;
    [SerializeField] float run = 6f;
    [SerializeField] int livePlayer = 3;
    [SerializeField] float cameraAxisX = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
        Camera();
    }

    private void Camera()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Debug.Log(cameraAxisX);
        Quaternion angulo = Quaternion.Euler(0f, cameraAxisX, 0f);
        transform.localRotation = angulo;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speedPlayer);
        }
    }

    private void Movement()
    {
        float vAxis = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * new Vector3(0, 0, vAxis) * Time.deltaTime);

        float hAxis = Input.GetAxisRaw("Horizontal");
        transform.Translate(speedPlayer * new Vector3(hAxis, 0, 0) * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedPlayer = run;
        }
        else
        {
            speedPlayer = 3f;
        }

    }
}
