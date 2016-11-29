using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyPartySpot : MonoBehaviour {

    public Image thisImage;

    public bool isFilled;

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

        if (thisImage.sprite != null)
        {
            isFilled = true;
        }

        else if (thisImage.sprite == null)
        {
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
}
