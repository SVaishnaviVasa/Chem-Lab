using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5.0f;  
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); 
        float verticalInput = Input.GetAxis("Vertical");     

      
        Vector3 forwardMovement = transform.forward * verticalInput;
        Vector3 rightMovement = transform.right * horizontalInput;

        
        transform.position += (forwardMovement + rightMovement) * speed * Time.deltaTime;
    }
}
