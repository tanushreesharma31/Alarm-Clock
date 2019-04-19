using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{

public int m;
public enum mode{
     ALARM_ON = 1,
     ALARM_OFF = 0,
     SET_ALARM = 2,
     SET_TIME = 3


     }   



 // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(m > 4)
       {

       m = 0;
        } 
    }
}
