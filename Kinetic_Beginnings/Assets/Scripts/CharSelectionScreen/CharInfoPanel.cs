using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharInfoPanel : MonoBehaviour {

    public Image charFace;
    public Image abilGraph;
    public Text bioText;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    public void GatherInfo(Sprite _charFace, Sprite _abilGraph, string _bioText)
    {
        if (charFace != null && abilGraph != null && bioText != null)
        {
            charFace.sprite = _charFace;
            abilGraph.sprite = _abilGraph;
            bioText.text = _bioText;
        }

        else
        {
            return;
        }
    }

    public void BackButton()
    {
        this.gameObject.SetActive(false);
    }
}
