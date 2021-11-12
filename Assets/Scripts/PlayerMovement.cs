using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    bool alive = true;

    public float currantSpeed = 5;

    AnimationController animController;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier;
    
    [SerializeField] float JumpForce = 400f;
    [SerializeField] LayerMask groundMask;
    private void FixedUpdate()
    {
        if (!alive) return;


        Vector3 forwardMove = transform.forward * currantSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * currantSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);


    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        if (transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;
        Invoke("Restart", 0);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask );

        if (Input.GetKeyDown("space"))
        {
            jump();
        } 
        rb.AddForce(Vector3.up * JumpForce);
    }






}

