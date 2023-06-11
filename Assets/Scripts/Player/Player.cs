using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int experience = 0;
    public int money = 0;
    public Mission mission;

    public void BuyingMission(){
        if (mission.isActive){
            mission.missionGoal.StoreBuy();
            if(mission.missionGoal.IsReached()){
                experience += mission.experienceReward;
                money += mission.moneyReward;
                
            }
        }
    }
    public void StudyMission(){
        if (mission.isActive){
            mission.missionGoal.StudyLesson();
            if(mission.missionGoal.IsReached()){
                experience += mission.experienceReward;
                money += mission.moneyReward;
            }
        }
    }
    public void RepairMission(){
        if (mission.isActive){
            mission.missionGoal.Repair();
            if(mission.missionGoal.IsReached()){
                experience += mission.experienceReward;
                money += mission.moneyReward;
            }
        }
    }
}
