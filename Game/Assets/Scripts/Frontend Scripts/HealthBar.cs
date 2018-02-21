using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

   // Stats playerStats;
    Slider healthBar;
    Text healthLabel;

    public Stats playerStats;

    
   

	// Use this for initialization
	void Start () {

        SetUpReferences();
        playerStats.GetComponent<HitDamage>().hasTakenDamage += PlayerHasTakenDamage;
        SetUpExceptions();
        SetHealthLabel();
    }

    private void SetUpReferences()
    {
        
        
        healthBar = GetComponent<Slider>();
        healthLabel = GetComponentInChildren<Text>();

    }
    private void SetUpExceptions()
    {
        if (playerStats == null)
        {
            throw new MissingComponentException("Missing Stats in HealthBar Script");
        }
        if (healthBar == null)
        {
            throw new MissingComponentException("Missing Slider in HealthBar Script");
        }

        if (healthBar == null)
        {
            throw new MissingComponentException("Missing Label in HealthBar Script");
        }
    }

    public void SetHealthLabel()
    {
        healthLabel.text = playerStats.Health.ToString();
    }	
	// Update is called once per frame
	void PlayerHasTakenDamage () {
        healthBar.value = playerStats.Health / 500;
        SetHealthLabel();
		
	}
}
