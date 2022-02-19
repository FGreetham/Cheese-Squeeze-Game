using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.UI;

public class CheeseBits : MonoBehaviour
{
    public ProgressBar progressBar;
    public Slider explosionSlider;

    public GameObject cheeseBits;

    /*Is there a better way to use the particle system instead of assigning it as a game object?
public ParticleSystem cheeseParticles;
Particle System -> cheeseBits.SetParticles(ParticleSystem); */


    private void Update()
    {
        //If value on slider reaches 95, particle system 'CheeseBits' activates;
        if (explosionSlider.value == 95)
        {
            CheeseExplosion();
        }

        if (explosionSlider.value < 1)
        {
            cheeseBits.gameObject.SetActive(false);
        }
    }

        public void CheeseExplosion()
    {
        cheeseBits.gameObject.SetActive(true);
       
        //Transforms particles to wherever cheese is.
       cheeseBits.transform.position = transform.position + new Vector3(0, 0, 0);
    }


}
