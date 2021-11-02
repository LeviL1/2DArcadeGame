using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasTank : MonoBehaviour
{
  
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
}
