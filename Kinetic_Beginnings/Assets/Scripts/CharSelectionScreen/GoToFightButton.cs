using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoToFightButton : MonoBehaviour {

    public Button thisButton;
    public Image[] partyImages = new Image[3];
    PartySpot spot;


	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        PartyCheck();
	}

    void PartyCheck()
    {
        foreach (Image pI in partyImages)
        {
            spot = pI.GetComponent<PartySpot>();
            if (spot.CheckIsFilled() == true)
            {
//                Debug.Log("IsFilled is true for " + pI.name);
                thisButton.interactable = true;
            }

            else
            {
                return;
            }
        }
    }
}
