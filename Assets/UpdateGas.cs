using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateGas : MonoBehaviour
{
  public Text gasText;

    // Update is called once per frame
    void Update()
    {
    gasText.text = ((int)GasTank.instance.gasAmt).ToString();
    }
}
