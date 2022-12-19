using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesBehaviour : MonoBehaviour
{
    public GameObject[] fire3;
    public float fire3Time = 3.0f;
    private float fire3Timer = 0.0f;

    public GameObject[] firesObstacles4_5;
    public float firesObstacles4_5Time = 0.2f;
    private float firesObstacles4_5Timer = 0.0f;

    public GameObject[] blades;
    public float blades1RotationSpeed = 0.4f;


    private void Start()
    {
        fire3[0].SetActive(false);
        fire3[1].SetActive(true);
        fire3[2].SetActive(true);
        fire3[3].SetActive(false);


        firesObstacles4_5[0].SetActive(true);
        firesObstacles4_5[1].SetActive(false);
        firesObstacles4_5[2].SetActive(false);
        firesObstacles4_5[3].SetActive(false);
        firesObstacles4_5[4].SetActive(false);
        firesObstacles4_5[5].SetActive(false);
        firesObstacles4_5[6].SetActive(false);
        firesObstacles4_5[7].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        fire3Timer += Time.deltaTime;
        firesObstacles4_5Timer += Time.deltaTime;

        if (fire3Timer > fire3Time)
        {
            fire3[0].SetActive(!fire3[0].activeSelf);
            fire3[1].SetActive(!fire3[1].activeSelf);
            fire3[2].SetActive(!fire3[2].activeSelf);
            fire3[3].SetActive(!fire3[3].activeSelf);


            fire3Timer = 0.0f;
        }

        for (int i = 0; i < blades.Length; i++)
        {
            blades[i].transform.Rotate(0.0f, 0.0f, blades1RotationSpeed * Time.deltaTime);
        }


        if (firesObstacles4_5Timer > firesObstacles4_5Time)
        {
            for (int i = firesObstacles4_5.Length-1; i >= 0; i--)
            {
                if (firesObstacles4_5[i].activeSelf)
                {
                    firesObstacles4_5[i].SetActive(false);
                    if (i == firesObstacles4_5.Length - 1)
                    {
                        firesObstacles4_5[0].SetActive(true);
                        firesObstacles4_5Timer = 0.0f;
                        i = -1;
                    }
                    else
                    {
                        firesObstacles4_5[i + 1].SetActive(true);
                    }
                }

                firesObstacles4_5Timer = 0.0f;
            }

        }
    }

}
