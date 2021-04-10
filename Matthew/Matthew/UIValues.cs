using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIValues : MonoBehaviour
{
    public int maxHappiness;
    public int CurrentHappiness = 0;

    public int happinessGain;

    public Text happyText;

    public Bar bar;

    void Start()
    {
        //CurrentHappiness = maxHappiness;
        //bar.SetMaxHealth(maxHappiness);
    }

    void Update()
    {
        happyText.text = "Happiness = " + CurrentHappiness;
    }

    public void GainRep()
    {
        CurrentHappiness = CurrentHappiness + happinessGain;

        bar.SetHealth(CurrentHappiness);
    }

    public void Play()
    {
        GainRep();
    }
    public void Interact()
    {
        GainRep();
    }
    public void Feed()
    {
        GainRep();
    }

}
