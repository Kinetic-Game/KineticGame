using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatUIHandler : MonoBehaviour {


	public GameObject HealthButton;
	public GameObject EnergyButton;
	public GameObject HealthMenu;
	public GameObject EnergyMenu;

	// Use this for initialization
	void Start () {
		HealthMenu.SetActive (false);
		EnergyMenu.SetActive (false);
		HealthButton.SetActive (true);
		EnergyButton.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HealthMenuOpen () {
		HealthMenu.SetActive (true);
		HealthButton.SetActive (false);
		EnergyButton.SetActive (false);
	
	}

	public void HealthMenuClose () {
		HealthMenu.SetActive (false);
		HealthButton.SetActive (true);
		EnergyButton.SetActive (true);

	}

	public void EnergyMenuOpen () {
		EnergyMenu.SetActive (true);
		HealthButton.SetActive (false);
		EnergyButton.SetActive (false);

	}

	public void EnergyMenuClose () {
		EnergyMenu.SetActive (false);
		HealthButton.SetActive (true);
		EnergyButton.SetActive (true);

	}
}
