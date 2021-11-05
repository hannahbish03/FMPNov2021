using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float currantSpeed = 5;
    public float walkSpeed = 3;
    public float runSpeed = 5;

    AnimationController animController;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * currantSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * currantSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);


    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
