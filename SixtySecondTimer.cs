using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixtySecondTimer : MonoBehaviour
{
    float time;
    TimeManager timeMgr;
    // Start is called before the first frame update
    public void HandleTimeout()
    {
     timeMgr.IncrementCurrentMinute();
     time = 0;     
    }   
    public void SetTimeManager(TimeManager newTimeMgr)
    {

     timeMgr = newTimeMgr;
     
     
    }

   public void Start()
    {
       timeMgr = GameObject.Find("TimeManager").GetComponent<TimeManager>(); 
       
    }

    // Update is called once per frame
    void Update()
    {
      time += UnityEngine.Time.deltaTime;
      if(time > 60f)
      {
      HandleTimeout();
      } 
    }
}
