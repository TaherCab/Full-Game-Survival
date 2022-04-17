using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    float cameraAxisX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera();
    }

    private void Camera()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Debug.Log(cameraAxisX);
        Quaternion angulo = Quaternion.Euler(0f, cameraAxisX, 0f);
        transform.localRotation = angulo;
    }
}
