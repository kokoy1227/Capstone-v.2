using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public float changeTime;
    public GameObject timeline;

    public GameObject _panels;

    private void Update()
    {
        changeTime -= Time.deltaTime;
        if(changeTime <= 0)
        {
            timeline.SetActive(false);
            _panels.SetActive(true);
        }
    }
}
