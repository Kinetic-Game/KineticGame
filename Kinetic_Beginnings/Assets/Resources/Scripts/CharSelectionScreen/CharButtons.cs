using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharButtons : MonoBehaviour {

    public CharInfoPanel panel;
    public Sprite charFace;
    public Sprite abilGraph;
    public string bioText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPress()
    {
        panel.GatherInfo(charFace, abilGraph, bioText);
        Button butt = this.gameObject.GetComponent<Button>();
        butt.interactable = false;
    }
}
