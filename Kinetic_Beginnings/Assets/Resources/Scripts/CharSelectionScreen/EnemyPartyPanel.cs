using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyPartyPanel : MonoBehaviour {

    public Image[] partySpot = new Image[3];

    public Sprite mySprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NextFight()
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
            return;
        }
    }
}
