using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateHealth : MonoBehaviour
{
  public Text healthTXT;
  private GasTank health;
  private void Start()
  {
    health = GameObject.FindGameObjectWithTag("Player").GetComponent<GasTank>();
  }
  private void Update()
  {
    healthTXT.text = health.carHealth.ToString();
  }
}
