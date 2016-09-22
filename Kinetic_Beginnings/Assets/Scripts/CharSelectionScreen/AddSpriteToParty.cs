﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddSpriteToParty : MonoBehaviour {

    public Sprite mySprite;

    public Image[] partySpot = new Image[3];
    
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPress()
    {
        if (partySpot[0].gameObject.activeInHierarchy == true && partySpot[0].GetComponent<PartySpot>().CheckIsFilled() == false)
        {
            partySpot[0].sprite = mySprite;
        }

        else if (partySpot[1].gameObject.activeInHierarchy == true && partySpot[1].GetComponent<PartySpot>().CheckIsFilled() == false)
        {
            partySpot[1].sprite = mySprite;
        }

        else if (partySpot[2].gameObject.activeInHierarchy == true && partySpot[2].GetComponent<PartySpot>().CheckIsFilled() == false)
        {
            partySpot[2].sprite = mySprite;
        }

        else
        {
            Debug.LogWarning("No active member of partySpot array found in " + this.name);
        }
    }
}
