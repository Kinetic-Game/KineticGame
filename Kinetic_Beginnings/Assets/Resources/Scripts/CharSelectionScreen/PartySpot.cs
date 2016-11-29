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
            if (thisButton.image.sprite.name == "Alex_Char_Select")
            {
                Button butt = GameObject.Find("AlexButton").GetComponent<Button>();
                butt.interactable = true;
            }

            if (thisButton.image.sprite.name == "Cass_Char_Select")
            {
                Button butt = GameObject.Find("CassieButton").GetComponent<Button>();
                butt.interactable = true;
            }

            if (thisButton.image.sprite.name == "Chris_Char_Select")
            {
                Button butt = GameObject.Find("ChrisButton").GetComponent<Button>();
                butt.interactable = true;
            }

            if (thisButton.image.sprite.name == "D_Char_Select")
            {
                Button butt = GameObject.Find("DimitriButton").GetComponent<Button>();
                butt.interactable = true;
            }

            if (thisButton.image.sprite.name == "Shyra_Char_Select")
            {
                Button butt = GameObject.Find("ShyraButton").GetComponent<Button>();
                butt.interactable = true;
            }

            if (thisButton.image.sprite.name == "Tori_Char_Select")
            {
                Button butt = GameObject.Find("ToriButton").GetComponent<Button>();
                butt.interactable = true;
            }

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
