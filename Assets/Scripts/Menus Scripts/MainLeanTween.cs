using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLeanTween : MonoBehaviour
{   
    [SerializeField]
    RectTransform MainCanvas;
    public RectTransform MainMenuPanel;
    public RectTransform LoadPanel;
    public RectTransform OptionPanel;
    public LeanTweenType intype;

    void Awake()
    {        
        MainCanvas = GameObject.FindWithTag("MainMenuCanvas").transform.GetChild(1).GetComponent<RectTransform>();
         ShowMainMenu();
    }
    public void ShowMainMenu(){
        MainMenuPanel.gameObject.SetActive(true);
        LeanTween.delayedCall(.1f,HideLoadGame);
        LeanTween.delayedCall(.1f,HideOptions);
        LeanTween.scale(MainMenuPanel,new Vector3(1,1,1),.3f).setDelay(.2f).setEase(intype);
    }
    public void HideMainMenu(){
        LeanTween.scale(MainMenuPanel,new Vector3(0,0,0),.1f).setEaseOutSine();
        MainMenuPanel.gameObject.SetActive(false);
    }
    public void ShowLoadGame(){
        LoadPanel.gameObject.SetActive(true);
        LeanTween.delayedCall(.1f,HideMainMenu);
        LeanTween.scale(LoadPanel,new Vector3(1,1,1),.2f).setDelay(.1f).setEase(intype);
    }
    public void HideLoadGame(){
        LeanTween.scale(LoadPanel,new Vector3(0,0,0),.1f).setEaseOutSine();
        LoadPanel.gameObject.SetActive(false);
    }
    public void ShowOptions(){
        OptionPanel.gameObject.SetActive(true);
        LeanTween.delayedCall(.1f,HideMainMenu);
        LeanTween.scale(OptionPanel,new Vector3(1,1,1),.2f).setDelay(.1f).setEase(intype);
    }
    public void HideOptions(){
        LeanTween.scale(OptionPanel,new Vector3(0,0,0),.1f).setEaseOutSine();
        OptionPanel.gameObject.SetActive(false);
    }
}
