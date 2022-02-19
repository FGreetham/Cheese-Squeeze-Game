using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider explosionSlider;
    //Sets up the variables used in this script
    private int currentProgress;
    private int startProgress = 0;


    public void SetProgress(int progress)
    {
        explosionSlider.value = progress;
    }

    private void Update()
    {
        //If slider value isn't 0, then start Reduce method.
        if (explosionSlider.value != 0f)
        {
            Reduce();
        }
    }

    /*Sets value on Progress bar script (SetProgress method) to the current progress which is the current progress set above
     *  + whatever number passed through Update Progress method in the update*/
    public void UpdateProgress(int clicks)
    {
        //Updates the current value to whatever the value on the slider is.
        currentProgress = (int)explosionSlider.value;

        currentProgress += clicks;
        SetProgress(currentProgress);

    }

    public void Reduce()
    {
        //Set the slider value to the new progress value (-5) over time.
        float numberToReduce = 1f;

        int newProgress = (int)(explosionSlider.value - numberToReduce * Time.deltaTime);

        SetProgress(newProgress);
    }
}
