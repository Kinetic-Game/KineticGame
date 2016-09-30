using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PartySpot : MonoBehaviour {

    bool isFilled;

    public Button thisButton;

	// Update is called once per frame
	void Update ()
    {
        IsSpriteFilled();
	}

    void IsSpriteFilled()
    {

        if (thisButton.image.sprite != null)
        {
            thisButton.image.color = Color.white;
            isFilled = true;
        }

        else if (thisButton.image.sprite == null)
        {
            thisButton.image.color = Color.clear;
            isFilled = false;
        }

        else
        {
            Debug.LogWarning("Can't tell if sprite is filled or not on " + this.name);
        }
    }

    public bool CheckIsFilled()
    {
        return isFilled;
    }

    public void OnPress()
    {
        if (thisButton.image.sprite != null)
        {
            thisButton.image.sprite = null;
            thisButton.image.color = Color.clear;
            isFilled = false;
        }

        else if (thisButton.image.sprite == null)
        {
            return;
        }

        else
        {
            return;
        }
    }
}
