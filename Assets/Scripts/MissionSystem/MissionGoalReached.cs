using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionGoalReached : MonoBehaviour
{
    public MissionProvider _missionProvider;
    public Player _player;
    public Mission _mission;

    public GameObject Panels;
    public GameObject _missionWindow;
    public Timelines _timelines;

    public void OnTriggerEnter(Collider other){
       _mission.goalLocation.SetActive(false);
        _mission.goalWaypoint.SetActive(false);
        _missionWindow.SetActive(false);
        Panels.SetActive(false);
        _timelines.timeline1.SetActive(true);

        

    }
}
