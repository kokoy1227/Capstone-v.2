using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionGoalReached : MonoBehaviour
{
    public MissionProvider _missionProvider;
    public Player _player;
    public Mission _mission;

    public GameObject _missionWindow;

    public void OnTriggerEnter(Collider other){
       _mission.goalLocation.SetActive(false);
        _mission.goalWaypoint.SetActive(false);
        _missionWindow.SetActive(false);
        SceneManager.LoadScene(5);

    }
}
