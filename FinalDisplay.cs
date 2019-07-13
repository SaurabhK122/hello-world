using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalDisplay : MonoBehaviour
{
    public ScriptObject x;//The user must create a new scriptable object and hence link this to that object.

    public Text display;
    public void Saving()
    {
        MainList.i++;
        //the instance created in accelerometer class is called here and its values are stored in the corresponding values of the scriptable object
        x.compassX = Compass.Instance.compassX;
        x.compassY = Compass.Instance.compassY;
        x.compassZ = Compass.Instance.compassZ;
        MainList.List2.Add(x);//this part of the code is essential when there are a large number of sensor data being stored. A list helps keep the number of elements stored till now

    }

    //This function is used to verify if the scriptable object stores the correct value. You might expect some delay in seeing the value stored.
    public void Show()
    {  
        display.text = MainList.List2[MainList.i].compassX.ToString();
    }

}    