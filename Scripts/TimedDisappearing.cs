using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDisappearing : MonoBehaviour
{
    public float nextActionTime = 0.0f;
    public float period = 1.0f;
    public float pause = 1.0f;
    public List<GameObject> fires;

    private void Start()
    {
        //pause = 2*pause + period;
        nextActionTime *= period + pause;
    }

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period + pause + period + pause;

            for (int i = 0; i < fires.Count; i++)
            {
                fires[i].gameObject.SetActive(true);
            }
        }
        if (Time.time > nextActionTime - (pause + period + pause))
        {
            for (int i = 0; i < fires.Count; i++)
            {
                fires[i].gameObject.SetActive(false);
            }
        }
    }
}
