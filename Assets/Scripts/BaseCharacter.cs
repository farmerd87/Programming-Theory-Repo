using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    protected abstract float Speed { get; set; }

    protected Rigidbody rb;
    protected abstract float TurnSpeed { get; set; }
    protected abstract float JumpForce { get; set; }

    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }



    public virtual void Move()
    {
        var horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        var verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * Speed;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }

        Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, horizontalInput * TurnSpeed, 0) * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);

        rb.AddRelativeForce(verticalInput, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
