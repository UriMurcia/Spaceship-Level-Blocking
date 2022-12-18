using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float forwardVelocity = 0.2f;
    public float moveVelocity = 0.5f;
    private Vector3 newPosition;

    private void Start()
    {
        newPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        newPosition.z = transform.position.z + forwardVelocity;
        
        float horizontalInput = Input.GetAxis("Horizontal");
        newPosition.x = transform.position.x + horizontalInput * moveVelocity;

        float verticalInput = Input.GetAxis("Vertical");
        newPosition.y = transform.position.y + verticalInput * moveVelocity;


        transform.position = newPosition;
    }
}
