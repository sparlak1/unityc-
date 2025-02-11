using UnityEngine;  

public class BallController : MonoBehaviour  
{
    public float moveSpeed = 10f;  
    public float jumpForce = 5f; 
    private Rigidbody rb;  

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        float moveZ = Input.GetAxis("Vertical");   

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ);

        rb.AddForce(moveDirection * moveSpeed);  
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}