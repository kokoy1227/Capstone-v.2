using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionProvider : MonoBehaviour
{
    public Mission _mission;
    public Player _player;
    public GameObject _missionWindow;

    public Text _title;
    public Text _description;
    public Text _story;


    public void OpenMissionWindow(){
        _missionWindow.SetActive(true);
        _title.text = _mission.title;
        _description.text = _mission.description;
        _story.text = _mission.story;
        
          
    }
    public void OnTriggerEnter(Collider other){
        
    }

    public void AcceptMission(){
        _missionWindow.SetActive(false);
        _mission.isActive = true;
        _player.mission = _mission;
        _mission.goalLocation.SetActive(true);
        _mission.goalWaypoint.SetActive(true);   
    }
}
