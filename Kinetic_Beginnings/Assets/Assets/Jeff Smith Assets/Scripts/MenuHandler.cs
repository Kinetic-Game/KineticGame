using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {

    [Tooltip("Type the first scene name to load here.")]
    public string Scene;

    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject CreditsMenu;
    public GameObject PlayerStoreMenu;
    public GameObject Earth;

    // Use this for initialization
    void Start () {
        OptionsMenu.SetActive(false);
        CreditsMenu.SetActive(false);
        PlayerStoreMenu.SetActive(false);
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

    public void ExitButton ()
    {
        Application.Quit();
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene(Scene);
    }

    public void PlayerStoreOpen()
    {
        MainMenu.SetActive(false);
        PlayerStoreMenu.SetActive(true);
        Earth.SetActive(false);
    }

    public void PlayerStoreClose()
    {
        MainMenu.SetActive(true);
        PlayerStoreMenu.SetActive(false);
        Earth.SetActive(true);
    }

}
