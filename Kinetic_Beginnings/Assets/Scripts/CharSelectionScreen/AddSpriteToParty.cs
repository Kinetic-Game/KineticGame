using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddSpriteToParty : MonoBehaviour {

    Sprite mySprite;

    public Button[] partySpot = new Button[3];

    CharInfoPanel cIP;

    public void OnPress()
    {

        if (partySpot[0].gameObject.activeInHierarchy == true && partySpot[0].GetComponent<PartySpot>().CheckIsFilled() == false)
        {
            cIP = GameObject.FindWithTag("CharInfoPanel").GetComponent<CharInfoPanel>();
            mySprite = cIP.charFace.sprite;
            partySpot[0].image.sprite = mySprite;
        }

        else if (partySpot[1].gameObject.activeInHierarchy == true && partySpot[1].GetComponent<PartySpot>().CheckIsFilled() == false)
        {
            cIP = GameObject.FindWithTag("CharInfoPanel").GetComponent<CharInfoPanel>();
            mySprite = cIP.charFace.sprite;
            partySpot[1].image.sprite = mySprite;
        }

        else if (partySpot[2].gameObject.activeInHierarchy == true && partySpot[2].GetComponent<PartySpot>().CheckIsFilled() == false)
        {
            cIP = GameObject.FindWithTag("CharInfoPanel").GetComponent<CharInfoPanel>();
            mySprite = cIP.charFace.sprite;
            partySpot[2].image.sprite = mySprite;
        }

        else
        {
            return;
        }
    }
}
