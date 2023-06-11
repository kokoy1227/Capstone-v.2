using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameController : MonoBehaviour
{
    RectTransform NewGameCanvas;
    public RectTransform MainPanel;
    public RectTransform MalePanel;
    public RectTransform FemalePanel;
    public LeanTweenType intype;
    void Awake()
    {        
        NewGameCanvas = GameObject.FindWithTag("NewCanvas").transform.GetChild(0).GetComponent<RectTransform>();
         ShowNewGame();
    }
    public void ShowNewGame(){
        LeanTween.scale(MainPanel,new Vector3(1,1,1),.2f).setDelay(.5f).setEase(intype);
    }
    public void ShowMalePanel(){
       FemalePanel.gameObject.SetActive(false);
       MalePanel.gameObject.SetActive(true);
    } 
    public void ShowFemalePanel(){
       MalePanel.gameObject.SetActive(false);
       FemalePanel.gameObject.SetActive(true);
    } 

}
