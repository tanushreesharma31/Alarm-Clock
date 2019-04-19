using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    public int amountofsoundobjects = 0;
    public float timer;
    public bool play = true;
    public GameObject soundobj;
    public void alarm()
    {



    }
    
    public void off()
    {



    }
     public void on()
     {
      if(timer % 5 > 4.9f && amountofsoundobjects == 0){
       play = !play;
       Instantiate(soundobj);
       amountofsoundobjects++;
      }

      }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     timer += UnityEngine.Time.deltaTime;        
     if((2.5+timer) % 5 > 4.9f)
     {
      amountofsoundobjects = 0;
      play = !play;

     }   
 
    }
    


}
