using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateScore : MonoBehaviour
{
  
  public Text scoreTxt;
    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = ScoreKeep.instance._score.ToString();
    }
}
