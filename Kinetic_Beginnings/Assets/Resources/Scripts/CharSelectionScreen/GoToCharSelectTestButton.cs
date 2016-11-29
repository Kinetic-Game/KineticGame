using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCharSelectTestButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnPress()
    {
        SceneManager.LoadScene(0);
    }
}
