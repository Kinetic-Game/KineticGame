using UnityEngine;
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
        if (charFace.sprite.name == "Alex_Char_Select")
        {
            Button butt = GameObject.Find("AlexButton").GetComponent<Button>();
            butt.interactable = true;
        }

        if (charFace.sprite.name == "Cass_Char_Select")
        {
            Button butt = GameObject.Find("CassieButton").GetComponent<Button>();
            butt.interactable = true;
        }

        if (charFace.sprite.name == "Chris_Char_Select")
        {
            Button butt = GameObject.Find("ChrisButton").GetComponent<Button>();
            butt.interactable = true;
        }

        if (charFace.sprite.name == "D_Char_Select")
        {
            Button butt = GameObject.Find("DimitriButton").GetComponent<Button>();
            butt.interactable = true;
        }

        if (charFace.sprite.name == "Shyra_Char_Select")
        {
            Button butt = GameObject.Find("ShyraButton").GetComponent<Button>();
            butt.interactable = true;
        }

        if (charFace.sprite.name == "Tori_Char_Select")
        {
            Button butt = GameObject.Find("ToriButton").GetComponent<Button>();
            butt.interactable = true;
        }

        this.gameObject.SetActive(false);
    }
}
