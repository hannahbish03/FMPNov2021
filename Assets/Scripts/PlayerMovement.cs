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



}
