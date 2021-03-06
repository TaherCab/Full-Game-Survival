using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    private Rigidbody rb;
    public LayerMask layerMask;
    public bool grounded;
    float cameraAxisX = 0f;
    private float speedPlayer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
       

    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            Grounded();
            Jump();
            Move();
            Camera();

            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Attack");
            }
        }

    }

    private void Camera()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        //Debug.Log(cameraAxisX);
        Quaternion angulo = Quaternion.Euler(0f, cameraAxisX, 0f);
        transform.localRotation = angulo;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.grounded)
        {
            this.rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }

    }


    private void Grounded()
    {
        if (Physics.CheckSphere(this.transform.position + Vector3.down, 0.2f, layerMask))

        {
            this.grounded = true;
        }

        else

        {
            this.grounded = false;
        }

        this.anim.SetBool("jump", !this.grounded);   
    }



    private void Move()
    {


        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");

        Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horizontalAxis;
        movement.Normalize();

        this.transform.position += movement * speedPlayer * Time.deltaTime;

        this.anim.SetFloat("vertical", verticalAxis);
        this.anim.SetFloat("horizontal", horizontalAxis);


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedPlayer = 3f;
            anim.SetBool("Run", true);
        }

        else
        {
            speedPlayer = 2f;
            anim.SetBool("Run", false);
        }



    }



}