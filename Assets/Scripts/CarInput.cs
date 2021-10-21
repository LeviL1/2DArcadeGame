using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInput : MonoBehaviour
{
  CarController car;
    // Start is called before the first frame update
    void Awake()
    {
    car = GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
    Vector2 inputVector = Vector2.zero;
    inputVector.x = Input.GetAxis("Horizontal");
    inputVector.y = Input.GetAxis("Vertical");

    car.SetInputVector(inputVector);
    }
}
