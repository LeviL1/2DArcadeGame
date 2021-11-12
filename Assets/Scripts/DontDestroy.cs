using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DontDestroy : MonoBehaviour
{
  private GameObject[] _score; //array of gameobjs
  public Text[] _scores;
  private void Awake()
  {

    DontDestroyOnLoad(this.gameObject); //Dont destroy music upon loading new scenes
  }
  private void Update()
  {
    _score = GameObject.FindGameObjectsWithTag("Score"); //find all music objs and fill _music with them

    if (_score.Length > 1) { Destroy(_score[1]); } //if more than one music player exists delete the additional one
    if (SceneManager.GetActiveScene().name == "ScrollingBG") 
    {
      for (int i = 0; i < _scores.Length; i++)
      {
        if (_scores[i].text == "0") 
        {
          _scores[i].text = ScoreKeep.instance._score.ToString();
          return;
        }
      }
      GasTank.instance.carHealth += 1;
    }
  }
}
