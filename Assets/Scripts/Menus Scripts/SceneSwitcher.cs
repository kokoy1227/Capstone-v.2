using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{   
    public void registerlogin(){
        SceneManager.LoadScene(0);
    }
    
    public void mainmenu(){
        SceneManager.LoadScene(1);
    }

    public void characterselect(){
        SceneManager.LoadScene(2);  
    }

    public void timeline(){
        SceneManager.LoadScene(3);
       
    }

    public void gameplay()
    {
        SceneManager.LoadScene(4);
    }

    public void exit(){
        SceneManager.LoadScene(1);
    }
    
}
