using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class FightSelectSpawn : MonoBehaviour {

    int level;
    public GameObject[] lvlPrefabs;
    bool lvlSpawned = false;


    public bool f1Active = false;
    public bool f2Active = false;
    public bool f3Active = false;
    public bool f4Active = false;
    public bool f5Active = false;
    public bool f6Active = false;
    public bool f7Active = false;
    public bool f8Active = false;
    public bool f9Active = false;
    public bool f10Active = false;
    public bool f11Active = false;

    // Use this for initialization
    void Start ()
    {
        f1Active = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        FightController();
	}

    // Use this method to control which enemies are displayed & which party members are active for each fight, also to spawn the level
    void FightController()
    {
        if (EditorSceneManager.GetActiveScene().name == "Character Select")
        {
            if (f1Active == false && f2Active == false && f3Active == false && f4Active == false && f5Active == false && f6Active == false && f7Active == false && f8Active == false && f9Active == false && f10Active == false && f11Active == false)
            {
                return;
            }
                
                //Check here for which fight is active, and set up char select screen approprately.
            if (f1Active == true)
            {
                //Alex is available, vs Dimitri
                Button butt = GameObject.Find("AlexButton").GetComponent<Button>();
                butt.interactable = true;

                //Set up eney fight panel here
                f1Active = false;
            }
            if (f2Active == true)
            {
                //Dimitri is available, vs chris
                Button butt = GameObject.Find("DimitriButton").GetComponent<Button>();
                butt.interactable = true;

                f2Active = false;
            }
            if (f3Active == true)
            {
                //Alex is available, vs Cassie
                Button butt = GameObject.Find("AlexButton").GetComponent<Button>();
                butt.interactable = true;

                //Set up eney fight panel here
                f3Active = false;
            }
            if (f4Active == true)
            {
                //Alex, Cassie, Dimitri, Chris is available, player can pick 2 vs Tori
                Button butt = GameObject.Find("AlexButton").GetComponent<Button>();
                butt.interactable = true;

                butt = GameObject.Find("DimitriButton").GetComponent<Button>();
                butt.interactable = true;

                butt = GameObject.Find("CassieButton").GetComponent<Button>();
                butt.interactable = true;

                butt = GameObject.Find("PartyMemberButton3").GetComponent<Button>();
                butt.gameObject.active = false;

                //Set up eney fight panel here
                f4Active = false;
            }
            if (f5Active == true)
            {

            }
            if (f6Active == true)
            {

            }
            if (f7Active == true)
            {

            }
            if (f8Active == true)
            {

            }
            if (f9Active == true)
            {

            }
            if (f10Active == true)
            {

            }
            if (f11Active == true)
            {

            }
        }

        else if (EditorSceneManager.GetActiveScene().name != "Character Select")
        {
            if (lvlSpawned == true)
            {
//              Check here to see if enemies or player has active characters, if not play either win or defeat screen and change to character select screen also call IncreaseLvl
                return;
            }

            if (lvlSpawned == false)
            {
                SpawnLevel();
            }
        }
    }

    void SpawnLevel()
    {
        Instantiate(lvlPrefabs[level]);

        lvlSpawned = true;
    }

    public bool ReturnLvlSpawn()
    {
        return lvlSpawned;
    }

    public void IncreaseLvl()
    {
        level++;
    }
}
