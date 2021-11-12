using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeep : MonoBehaviour
{
  public static ScoreKeep instance;
  [SerializeField] public int _score = 0;
  private void Awake()
  {
    if (ScoreKeep.instance == null)
    {
      ScoreKeep.instance = this;
    }
    else if (ScoreKeep.instance != this)
    {
      Destroy(this);
    }
  }

  // Update is called once per frame
  void Update()
    {
    if (GasTank.instance.gasAmt > 0 && GasTank.instance.carHealth > 0)
    {
      StartCoroutine(ScoreCoroutine());
    }
    
    else { StopCoroutine(ScoreCoroutine()); }
    }
  IEnumerator ScoreCoroutine() 
  {
    _score += 10;
    yield return new WaitForSeconds(1f);

  }
  public static void SubtractScore() 
  {
    ScoreKeep.instance._score -= 10000;
  }
}
