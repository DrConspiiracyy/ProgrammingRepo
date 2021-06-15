using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Slider timerSlider;
       
    public void MeterMode(float value)
    {
        timerSlider.value = value;
    }


    public int gameover
    {
        


    }
   
    void Update()
    {
        if (timerSlider > 0)
        {
            
        }
        else if (value <= 0)
        {
            gameover = true;
        }




    }
}
