using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    

    public void PlayGame(){
        SceneManager.LoadScene("level0");
    }
     public void QuitGame(){
        Application.Quit();
     }
}
