using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasTank : MonoBehaviour
{
  public static GasTank instance;
  public List<float> scores = new List<float>();
  private void Awake()
  {
    if (GasTank.instance == null)
    {
      GasTank.instance = this;
    }
    else if (GasTank.instance != this)
    {
      Destroy(this);
    }
  }
  public float gasAmt;
  public float carHealth;
    void FixedUpdate()
    {
      if (gasAmt != 0)
      {
        StartCoroutine(LoseGas());
      }
      else StopCoroutine(LoseGas());
    }
    IEnumerator LoseGas()
    {
      gasAmt -= 0.05f;
      yield return new WaitForSeconds(1.25f);
    }
  public void GetWrecked(float dmg) 
  {
    carHealth -= dmg;
  }
  private void Update()
  {
    if (carHealth <= 0) 
    {
      scores.Add(ScoreKeep.instance._score);
    }
  }
}
