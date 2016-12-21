using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FightSelectSpawn : MonoBehaviour {

    int level;
    public GameObject[] lvlPrefabs;
    bool lvlSpawned = false;
    int f = 0;



    // Use this for initialization
    void Start ()
    {
        IncreaseFight();
	}
	
	// Update is called once per frame
	void Update ()
    {
        FightController();
	}

    // Use this method to control which enemies are displayed & which party members are active for each fight, also to spawn the level
    void FightController()
    {
        if (SceneManager.GetActiveScene().name == "Character Select")
        {
            if (f==0)
            {
                return;
            }
                
                //Check here for which fight is active, and set up char select screen approprately.
            if (f == 1)
            {
                //Alex is available, vs Dimitri
                Button butt = GameObject.Find("AlexButton").GetComponent<Button>();
                butt.interactable = true;

                //Set up eney fight panel here

            }
            if (f == 2)
            {
                //Dimitri is available, vs chris
                Button butt = GameObject.Find("DimitriButton").GetComponent<Button>();
                butt.interactable = true;

            }
            if (f == 3)
            {
                //Alex is available, vs Cassie
                Button butt = GameObject.Find("AlexButton").GetComponent<Button>();
                butt.interactable = true;

                //Set up eney fight panel here

            }
            if (f == 4)
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

            }
            if (f == 5)
            {

            }
            if (f == 6)
            {

            }
            if (f == 7)
            {

            }
            if (f == 8)
            {

            }
            if (f == 9)
            {

            }
            if (f == 10)
            {

            }
            if (f == 11)
            {

            }
        }

        else if (SceneManager.GetActiveScene().name != "Character Select")
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

    public void IncreaseFight()
    {
        f++;
    }
}
