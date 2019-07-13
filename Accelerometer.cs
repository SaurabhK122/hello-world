using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public static Accelerometer Instance { set; get; }

    public float accX;
    public float accY;
    public float accZ;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    private void Update()
    {
        accX = Input.acceleration.x;
        accY = Input.acceleration.y;
        accZ = Input.acceleration.z;
    }
}