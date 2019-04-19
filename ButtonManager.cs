using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    

    ModeManager modeMgr;
    TimeManager timeMgr;     
    public void buttonManager()
    {

    }

    public void DoAlarmOff()
    {
     int temp = (int)Mode.mode.ALARM_OFF;
     modeMgr.getmode().m = temp;
    }    
    public void DoAlarmOn()
    {
     int temp = (int)Mode.mode.ALARM_ON;
     modeMgr.getmode().m = temp;

    }
    public void DoIncrementHour()
   {
    int temp = (int)Mode.mode.SET_ALARM;
    if(modeMgr.getmode().m  == temp)
    {
     timeMgr.IncrementAlarmHour();


     }
    temp = (int)Mode.mode.SET_TIME;
    if(modeMgr.getmode().m  == temp)
    {
     timeMgr.IncrementCurrentHour();


     } 
    }
    public void DoIncrementMinute()
    {
    Mode md = modeMgr.getmode();
    int temp = (int)Mode.mode.SET_ALARM;
    if(modeMgr.getmode().m  == temp)
    {
     timeMgr.IncrementAlarmMinute();


     }
    temp = (int)Mode.mode.SET_TIME;
    if(modeMgr.getmode().m  == temp)
    {
     timeMgr.IncrementCurrentMinute();


     } 


    }
    public void DoSetAlarm()
   {
   int temp = (int)Mode.mode.SET_ALARM;
   modeMgr.getmode().m = temp;
   }
    public void DoSetTime()
   {
    int temp = (int)Mode.mode.SET_TIME;
    modeMgr.getmode().m  = temp;

    }

    public void DoSnooze()
    {
     timeMgr.IncrementAlarmMinute();
     timeMgr.IncrementAlarmMinute();
     timeMgr.IncrementAlarmMinute();
     timeMgr.IncrementAlarmMinute();
     timeMgr.IncrementAlarmMinute();
     


    }
    public void SetModeManager(ModeManager newModeManager)
    {

    }
    public void SetTimeManager(TimeManager timeManager)
   {

   }

    // Start is called before the first frame update
    void Start()
    {
        timeMgr = GameObject.Find("TimeManager").GetComponent<TimeManager>();
        modeMgr = GameObject.Find("ModeManager").GetComponent<ModeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
