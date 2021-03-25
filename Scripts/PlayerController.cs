using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1.0f;
    public float slowspeed = 1.0f;
    public float turnSpeed = 1.0f;
    public float horizontalInput;
    public float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * slowspeed);
        transform.Translate(Vector3.forward * speed * verticalInput);
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
