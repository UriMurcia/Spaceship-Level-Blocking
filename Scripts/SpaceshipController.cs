using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float forwardVelocity = 0.2f;
    public float moveVelocity = 0.5f;
    public GameObject spaceship;


    private Vector3 forwardPosition;
    private Vector3 spaceshipPosition;
    private Vector3 spaceshipRotation;


    private void Start()
    {
        forwardPosition = transform.position;
        spaceshipPosition = spaceship.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        forwardPosition.z = transform.position.z + forwardVelocity * Time.deltaTime;

        transform.position = forwardPosition;



        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        spaceshipPosition.z = spaceship.transform.position.z;
        spaceshipPosition.x = spaceship.transform.position.x + horizontalInput * moveVelocity * Time.deltaTime;
        spaceshipPosition.y = spaceship.transform.position.y + verticalInput * moveVelocity * Time.deltaTime;
        spaceship.transform.position = spaceshipPosition;


        spaceshipRotation.z = spaceship.transform.rotation.z - (horizontalInput * Time.deltaTime * 90.0f);
        //spaceshipRotation.x = spaceship.transform.rotation.x - verticalInput * Time.deltaTime * 90.0f;
        spaceshipRotation.x = 0.0f;
        spaceshipRotation.y = 0.0f;
        spaceship.transform.Rotate(spaceshipRotation, Space.Self);
        
    }
}
