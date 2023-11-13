using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Car
{
    public float speed;
    public string color;
    public int highestSpeed;

    public Car()
    {
        Debug.Log("Car()  Called");
    }

    public Car(float speed)
    {
        this.speed = speed;
        Debug.Log("Car(float)  Called");
    }
    public Car(float speed, string color)
    {
        this.speed = speed;
        this.color = color; 
        Debug.Log("Car(float, string) Called");
    }

    public Car(float speed, string color, int highestSpeed)
    {
        this.speed = speed;
        this.color = color;
        this.highestSpeed = highestSpeed;
    }

    void Move()
    {
        Debug.Log("Moving");


    }

    void ApplyBrake()
    {
        Debug.Log("Applying Brake");

    }

    public void CarSpeed()
    {
        Debug.Log(speed);
    }

    public void PrintCarDetails()
    {
        Debug.Log($"Speed = {speed}, Color = {color}, Highest Speed = {highestSpeed}");
    }

}


