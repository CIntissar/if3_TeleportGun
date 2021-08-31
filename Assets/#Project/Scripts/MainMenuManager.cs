using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
   public void StartGame()
   {
        SceneManager.LoadScene("MainScene");
   }
    public void TutorialGame()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
