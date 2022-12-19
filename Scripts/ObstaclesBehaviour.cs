using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesBehaviour : MonoBehaviour
{
    public GameObject[] fire2;
    public float fire2Time = 3.0f;
    private float fire2Timer = 0.0f;

    public GameObject blades1;
    public float blades1RotationSpeed = 0.4f;


    private void Start()
    {
        fire2[0].SetActive(true);
        fire2[1].SetActive(false);
        fire2[2].SetActive(false);
        fire2[3].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        fire2Timer += Time.deltaTime;

        if (fire2Timer > fire2Time)
        {
            fire2[0].SetActive(!fire2[0].activeSelf);
            fire2[1].SetActive(!fire2[1].activeSelf);
            fire2[2].SetActive(!fire2[2].activeSelf);
            fire2[3].SetActive(!fire2[3].activeSelf);


            fire2Timer = 0.0f;
        }

        blades1.transform.Rotate(0.0f, 0.0f, blades1RotationSpeed * Time.deltaTime);
    }


}
