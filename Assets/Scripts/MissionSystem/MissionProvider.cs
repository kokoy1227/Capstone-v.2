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


    private void Awake() {
        OpenMissionWindow();
    }

    public void OpenMissionWindow(){
        _missionWindow.SetActive(true);
        _title.text = _mission.title;
        _description.text = _mission.description;
        _mission.isActive = true;
        _player.mission = _mission;
        _mission.goalLocation.SetActive(true);
        _mission.goalWaypoint.SetActive(true);   
    }
}
