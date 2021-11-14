using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GasTank : MonoBehaviour
{
  public static GasTank instance;
  public Canvas deathcanvas;
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
  private void Start()
  {
    Time.timeScale = 1;
    deathcanvas.enabled = false;
  }
  public float gasAmt;
  public float carHealth;
    void FixedUpdate()
    {
      if (gasAmt >= 0)
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
      Time.timeScale = 0f;
      StopAllCoroutines();
      deathcanvas.enabled = true;

    }
  }

}
