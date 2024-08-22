using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed;
    public Transform orientation;
    public float groundDrag;

    private float horizontalInput;
    private float verticalInput;
    private Vector3 moveDirection;
    public bool isWalking;
    public AudioSource Asource;


    [Header("Ground check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    private bool grounded;

    [Header("No Clip")]
    private Rigidbody rb;
    public CapsuleCollider CC;

    // Start is called before the first frame update
    private void Start()
    {
        CC.GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        CC.enabled = true;
        rb.isKinematic = false;
    }

    // Update is called once per frame
    private void Update()
    {
        MyInput();
        SpeedControl();

        //ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        //handle drag
        if (grounded)
        {
            
            rb.drag = groundDrag;
        }
        else
        {
            isWalking = false;
            rb.drag = 0;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            CC.enabled = false;
            rb.useGravity = false;
            isWalking = false;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
                CC.enabled = true;
                rb.useGravity = true;
                isWalking = true;
        }

        if (horizontalInput> 0|| horizontalInput < 0 ||verticalInput > 0 || verticalInput < 0)
        {

            if (!Asource.isPlaying)
            {

                Walk();
            }
            
        }
        else
        {
            Walknt();
        }


    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //This calculates movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        

        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }


    }

    void Walk()
    {
        Asource.Play();

    }

    void Walknt()
    {
        Asource.Stop();

    }
}
