using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // the information about each individual axle

    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have
    public float motor;
    public float steering;

    public int multiplier = 1;

    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        // motor = maxMotorTorque * Input.GetAxis("Vertical");
        motor = maxMotorTorque * multiplier;
        // steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }


        }
    }


    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.otherCollider.name == "Car  5")
            {
                print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
                contact.otherCollider;
            }

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