using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public bool choque = false;
    
    public float speed =5f;
    
    // Start is called before the first frame update
  
    private void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!choque)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.name)
        {
           case "Car1": choque = true; break;
           case "Car2": choque = true; break;
           case "Car3": choque = true; break;
           case "Car4": choque = true; break;
           case "Car5": choque = true; break;
           case "Car6": choque = true; break;
        }
    }



}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}