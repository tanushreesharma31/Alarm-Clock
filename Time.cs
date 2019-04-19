using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time
{
    
    int hour;
    int minute;

   public void AddOneMinute()
    {
    


    }
   public bool Equate(Time a, Time b)
   {
   if(a.hour == b.hour && a.minute == b.minute)
   {
   
   
   return true;
   }
   return false;
   }  
   public int GetHour()
   {
    return hour;

   }   
   public int GetMinute()
   {
    return minute;
    }    
    public void IncrementHour()
    {
     hour++;
     if(hour > 12)
     {
      hour = 0;
     }

     }
    public void IncrementMinute()
    {
     minute++;
     if(minute > 59)
     {
      minute = 0;
      IncrementHour();
     }

    }
    public void time(int inHour, int inMinute)
    {
     hour = inHour;
     minute = inMinute;


    }   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
