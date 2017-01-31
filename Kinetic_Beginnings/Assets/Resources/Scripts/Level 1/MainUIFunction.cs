using UnityEngine;
using System.Collections;

public class MainUIFunction : MonoBehaviour {

	//public bool whenPressed;

	public GameObject camera;

	public GameObject cameraOne;

	public Animator attackTest;

    public bool attackPressed;

    public bool defendPressed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void DisableCamera1()
	{
		cameraOne.SetActive (false);
	}

	public void OnPressAttack()
	{
		print ("Pow!");

		attackPressed = true;

		//attackTest.SetBool ("whenPressed", true);

		attackTest.Play ("AttackTest");

		cameraOne.SetActive (true);

		Invoke("DisableCamera1", 2.0f);
	}

	public void OnPressDefend()
	{
		print ("Protect!");

        defendPressed = true;
	}

	public void OnPressKinesis()
	{
		print ("Power!");
	}

	public void OnPressRest()
	{
		print ("Pant!");
	}

	public void OnPressHealth()
	{
		print ("Phew!");
	}

	public void OnPressEnergy()
	{
		print ("Potion!");
	}
}
