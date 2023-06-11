using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{   
    public void register(){
        SceneManager.LoadScene(0);
    }
    public void login(){
        SceneManager.LoadScene(1);
    }
    
    public void mainmenu(){
        SceneManager.LoadScene(2);
    }

    public void newgame(){
        SceneManager.LoadScene(3);
    }

    public void gameplay(){
        SceneManager.LoadScene(4);
       
    }

    public void quiz(){
        SceneManager.LoadScene(5);
       
    }

    public void exit(){
        SceneManager.LoadScene(1);
    }
    
}
