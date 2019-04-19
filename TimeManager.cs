using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
   Alarm alarm;
   Time alarmTime;
   Time currentTime;
   Display display;    
   ModeManager modeMgr;
   Time snoozeTime;
   public void IncrementAlarmHour()
   {
    alarmTime.IncrementHour();
   }
   public void IncrementAlarmMinute()
   {
    alarmTime.IncrementMinute();
   }    
   public void IncrementCurrentHour()
   {
    currentTime.IncrementHour();
   }
   public void IncrementCurrentMinute()
   {
    currentTime.IncrementMinute();
   }
   public void SetAlarm(Alarm alarm)
   {
    

   }
   public void SetDisplay(Display newDisplay)
   {



   }
   public void SetModeManager(ModeManager newModeManager)
   {
   
   }

   public void ShowAlarmTime()
   {
    GameObject.Find("Display/Canvas/AlarmHours").GetComponent<Text>().text = "" ; 
    GameObject.Find("Display/Canvas/AlarmMinutes").GetComponent<Text>().text = "";
    if(alarmTime.GetHour() < 10)
    {
     GameObject.Find("Display/Canvas/AlarmHours").GetComponent<Text>().text += "0";
    }

    if(alarmTime.GetMinute() < 10)
    {
    GameObject.Find("Display/Canvas/AlarmMinutes").GetComponent<Text>().text += "0";

    }

    GameObject.Find("Display/Canvas/AlarmHours").GetComponent<Text>().text += alarmTime.GetHour().ToString();
    GameObject.Find("Display/Canvas/AlarmMinutes").GetComponent<Text>().text += alarmTime.GetMinute().ToString();
   }
   public void ShowCurrentTime()
   {
    GameObject.Find("Display/Canvas/CurrentHours").GetComponent<Text>().text = "" ; 
    GameObject.Find("Display/Canvas/CurrentMinutes").GetComponent<Text>().text = "";
    if(currentTime.GetHour() < 10)
    {
     GameObject.Find("Display/Canvas/CurrentHours").GetComponent<Text>().text += "0";
    }

    if(currentTime.GetMinute() < 10)
    {
    GameObject.Find("Display/Canvas/CurrentMinutes").GetComponent<Text>().text += "0";

    }
    


    GameObject.Find("Display/Canvas/CurrentHours").GetComponent<Text>().text += currentTime.GetHour().ToString();
    GameObject.Find("Display/Canvas/CurrentMinutes").GetComponent<Text>().text += currentTime.GetMinute().ToString();
   }
   public void Snooze()
   {

   } 
   public void timeManager()
   {

   }

  
 // Start is called before the first frame update
    void Start()
    {
        currentTime = new Time();
        currentTime.time(System.DateTime.Now.Hour%12,System.DateTime.Now.Minute);
        alarmTime = new Time();
        modeMgr = GameObject.Find("ModeManager").GetComponent<ModeManager>();
        alarm = GameObject.Find("Alarm").GetComponent<Alarm>();        
    }

    // Update is called once per frame
    void Update()
    {
        int temp = (int)Mode.mode.ALARM_ON;
        //modeMgr.getmode().m = temp;
        ShowAlarmTime();
        ShowCurrentTime();
        if(alarmTime.Equate(alarmTime,currentTime)&&modeMgr.getmode().m == temp)
        {
         alarm.on();
         Debug.Log("Play Alarm");
        }    

    }
}
