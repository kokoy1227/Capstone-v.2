using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject OptionPanel;
    public GameObject PauseButton;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause(){
        PausePanel.SetActive(true);
        OptionPanel.SetActive(false);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }
    public void Resume(){
        PausePanel.SetActive(false);
        OptionPanel.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void Options(){
        OptionPanel.SetActive(true);
        PausePanel.SetActive(false);

    }
    
}
