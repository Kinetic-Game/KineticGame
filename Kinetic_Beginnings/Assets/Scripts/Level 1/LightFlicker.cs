using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {

	public Light lt;

	public float flickerTimer;

	public bool didFlicker = false;

	public bool flickOn = false;

	public bool gonnaFlicker = false;

	public bool lastFlicker = false;

	public float flickerTimerMax;

	public float flickTimerTwo;

	public float lastFlickTimer;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

		FlickTheLight ();

	}

	void FlickTheLight ()
	{
		if (didFlicker == false) {
			flickerTimer += Time.deltaTime;
		}
		//flickerTimer += Time.deltaTime;
		if (flickerTimer >= 1)
		{
			lt = GetComponent<Light>();
			lt.intensity = 1;
			flickerTimer = 0;
			gonnaFlicker = true;
			didFlicker = true;

		//	FlickTheLightOn ();
				
		}
		if (gonnaFlicker == true) {
			flickerTimerMax += Time.deltaTime;
		}
		if (flickerTimerMax >= .3) 
		{
			gonnaFlicker = false;
			//flickTimerTwo += Time.deltaTime;
			flickOn = true;
			lt.intensity = 0;
			flickerTimerMax = 0;

		//	FlickTheLightAgain ();
		}
		if (flickOn == true) {
			flickTimerTwo += Time.deltaTime;
		}
		if (flickTimerTwo >= .3) 
		{
			flickOn = false;
			lt.intensity = 1;
			flickTimerTwo = 0;
			lastFlicker = true;
			//FlickTheLight ();
		}

		if (lastFlicker == true) {
			lastFlickTimer += Time.deltaTime;
		}

		if (lastFlickTimer >= .3) 
		{
			gonnaFlicker = false;
			//flickTimerTwo += Time.deltaTime;
			didFlicker = false;
			lt.intensity = 0;
			lastFlickTimer = 0;

			//	FlickTheLightAgain ();
		}
			
	}
		
}
