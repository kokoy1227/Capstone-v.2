using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    
    
    RectTransform MainCanvas;
    public RectTransform MainMenuPanel;
    public RectTransform LoadPanel;
    public RectTransform OptionPanel;
    public RectTransform SoundPanel;
    public LeanTweenType intype;
    void Awake()
    {        
        MainCanvas = GameObject.FindWithTag("MainMenuCanvas").transform.GetChild(0).GetComponent<RectTransform>();
         ShowMainMenuPanel();
    }
    public void ShowMainMenuPanel(){
            if(!MainMenuPanel.gameObject == true){
                MainMenuPanel.gameObject.SetActive(true); 
            }
        LeanTween.scale(MainMenuPanel,new Vector3(1,1,1),1f).setDelay(.5f).setEase(intype);
    }
    public void HideMainMenuPanel(){
            LeanTween.scale(MainMenuPanel,new Vector3(0,0,0),.5f).setEaseOutSine();
            LeanTween.move(MainMenuPanel,new Vector3(0,0,0),.7F).setOnComplete(OnHideMainMenuPanel);
    }
    public void ShowLoadPanel(){
            LeanTween.scale(LoadPanel,new Vector3(1,1,1),1f).setDelay(.5f).setOnComplete(OnHideMainMenuPanel);               
            LeanTween.delayedCall(.5f,HideMainMenuPanel);
    }
    public void HideLoadPanel(){
            LeanTween.scale(LoadPanel,new Vector3(0,0,0),.5f).setEaseOutSine();
            LeanTween.delayedCall(.5f,ShowMainMenuPanel);
    }
    public void ShowOptionPanel(){
            LeanTween.scale(OptionPanel,new Vector3(1,1,1),1f).setDelay(1.5f).setOnComplete(OptionPanelFinalPosition);               
            LeanTween.delayedCall(.5f,HideMainMenuPanel);
    }
    public void OptionPanelFinalPosition(){
            LeanTween.scale(OptionPanel,new Vector3(.7f,.7f,.7f),.5f).setEaseOutQuint();
    }
    public void HideOptionPanel(){
            LeanTween.scale(OptionPanel,new Vector3(0,0,0),.5f).setEaseInBounce();
            LeanTween.move(OptionPanel,new Vector3(0,0,0),.7F);
    }
    public void OnHideMainMenuPanel(){
       MainMenuPanel.gameObject.SetActive(false);
    } 
    
}
