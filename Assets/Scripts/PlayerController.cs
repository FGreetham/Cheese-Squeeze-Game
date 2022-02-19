using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //References the slider with "Progress Bar" script - this is added to Inspector
    public ProgressBar progressBar;

    //Sets up the variables used in this script
    private int currentProgress;
    private int startProgress = 0;
    private int updatedProgress;

    void Start()
    {
        /*Accesses the attached progress bar script method "SetProgress" 
        and sets the slider.value to Start Progress value above which = 0 */
        currentProgress = startProgress;
        progressBar.SetProgress(startProgress);
    }

   
    private void Update()
    {
        // Whenever spacebar pressed, the update progress method is called (value of 40 added to progress)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            progressBar.UpdateProgress(40); 
        }
    }

}
