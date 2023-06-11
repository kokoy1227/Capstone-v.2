using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionGoalReached : MonoBehaviour
{
    public MissionProvider _missionProvider;
    public Player _player;
    public Mission _mission;

    public GameObject QuizPanel;
    public GameObject _missionWindow;
    public GameObject _missionLocation;

    public void OnTriggerEnter(Collider other){
        

        if (_missionProvider._mission.missionGoal.IsReached())
            _missionLocation.SetActive(false);
            
         
    }
}
