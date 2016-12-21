using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour {

	public GameObject PauseMenu;
	public GameObject SceneTitle;

	private string CurrentScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MainMenuButton()
	{
		Time.timeScale = 1.0f;
		SceneManager.LoadScene("MainMenu");
	}

	public void PauseMenuOpen () {

		Time.timeScale = 0.0f;
		SceneTitle.SetActive (false);
		PauseMenu.SetActive (true);
	}

	public void ResumeButton () {

		Time.timeScale = 1.0f;
		PauseMenu.SetActive (false);
		SceneTitle.SetActive (true);
	}

	public void RestartButton () {
		Time.timeScale = 1.0f;
		CurrentScene = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene(CurrentScene);
	}
}
