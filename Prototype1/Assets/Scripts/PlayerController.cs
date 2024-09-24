using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera mainCamera; 
    public Camera hoodCamera; 
    public KeyCode switchKey;
    public string inputID;
    //private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"+inputID);
        verticalInput = Input.GetAxis("Vertical"+inputID);
        //Move the car forward based on verticalinput
        transform.Translate(Vector3.forward * Time.deltaTime *  speed * verticalInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


        if (Input.GetKeyDown(switchKey)) 
        { mainCamera.enabled = !mainCamera.enabled;
          hoodCamera.enabled = !hoodCamera.enabled; 
        
        }

    }
}
