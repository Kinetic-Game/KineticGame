using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PartySpot : MonoBehaviour {

    public bool isFilled;
    public Image thisObject;
    //public Button thisButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        IsSpriteFilled();
	}

    void IsSpriteFilled()
    {
        if (thisObject.sprite != null)
        {
            isFilled = true;
        }

        else if (thisObject.sprite == null)
        {
            isFilled = false;
        }

        else
        {
            Debug.LogWarning("Can't tell if sprite is filled or not on " + this.name);
        }

        //if (thisButton.GetComponent<Sprite>() != null)
        //{
        //    isFilled = true;
        //}

        //else if (thisButton.GetComponent<Sprite>() == null)
        //{
        //    isFilled = false;
        //}

        //else
        //{
        //    Debug.LogWarning("Can't tell if sprite is filled or not on " + this.name);
        //}
    }

    public bool CheckIsFilled()
    {
        return isFilled;
    }
}
