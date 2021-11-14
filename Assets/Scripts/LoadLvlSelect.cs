using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLvlSelect : MonoBehaviour
{

  
   
  public void LoadLVL1()
  {

    SceneManager.LoadScene("ScrollingBG", LoadSceneMode.Single);
  }
  public void LoadLVL2()
  {
    SceneManager.LoadScene("Lvl2", LoadSceneMode.Single);
  }
  
  public void LoadMainMenu()
  {
    SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    
  }
  public void Exit()
  {
    Application.Quit();
  }
}
