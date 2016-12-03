using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject CreditsMenu;

    // Use this for initialization
    void Start () {
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OptionsButtonOpen ()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);

    }

    public void OptionsButtonClose()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    public void CreditsButtonOpen()
    {
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(true);

    }

    public void CreditsButtonClose()
    {
        OptionsMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }



}
