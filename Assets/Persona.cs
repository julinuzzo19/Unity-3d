using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    Rigidbody rd;

    public bool colision = false;
   
    public Car car;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (car.choque)
        {
            transform.Rotate(car.speed,0,0);
            StartCoroutine(ExampleCoroutine());

            car.speed = 0;
            car.choque = false;
        }
    }


    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        transform.Rotate(-10, 0, 0);
    }
}
