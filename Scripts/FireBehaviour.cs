using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    public bool fireLeftToRight = false;
    public bool fireRotation = false;

    private float fireMin = 0.0f;
    public float fireMax = 0.0f;
    public float fireLeftRightSpeed = 0.02f;
    private float direction = 1.0f;

    public float rotationSpeed = 0.0f;


    private void Start()
    {
        fireMin = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (fireLeftToRight)
        {
            
            if (this.gameObject.transform.position.x < fireMin)
            {
                direction = 1.0f;
            }
            if (this.gameObject.transform.position.x > fireMax)
            {
                direction = -1.0f;
            }
            float move = -fireLeftRightSpeed * direction * Time.deltaTime;
            this.gameObject.transform.Translate(0, move, 0);
        }

        if (fireRotation)
        {
            transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        }

        

    }
}
