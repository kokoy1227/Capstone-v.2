

[System.Serializable]
public class MissionGoal
{
   public MissionGoalType _goalType;
   public int _requiredAmount;
   public int _currentAmount;
   
   public bool IsReached()
   {
    return (_currentAmount >= _requiredAmount);
   }
   public void StoreBuy(){
        if (_goalType == MissionGoalType.Buying)
        _currentAmount++;
   }
   public void StudyLesson(){
        if (_goalType == MissionGoalType.Studying)
        _currentAmount++;
        
   }
   public void Repair(){
        if (_goalType == MissionGoalType.Repairing)
        _currentAmount++;
   }
}

public enum MissionGoalType
{
    Buying,
    Studying,
    Repairing
}