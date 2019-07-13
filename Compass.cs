using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public static Compass Instance { set; get; }

    public float compassX;
    public float compassY;
    public float compassZ;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        Input.compass.enabled = true;
    }

    private void Update()
    {

        compassX = Input.compass.rawVector.x;
        compassY = Input.compass.rawVector.y;
        compassZ = Input.compass.rawVector.z;
    }
}