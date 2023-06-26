using System;
using UnityEngine;

[Serializable]
public class Mission
{
    public bool isActive;
    public string title;
    public string description;
    public int experienceReward;
    public int moneyReward;
    public MissionGoal missionGoal;
    public GameObject goalLocation;
    public GameObject goalWaypoint;
  
}
