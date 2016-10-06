using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class PartySelectSpawn : MonoBehaviour {

    public Button[] partySpot = new Button[3];

    public GameObject[] plyrSpawnPoints = new GameObject[3];

    public GameObject[] plyrPrefabs = new GameObject[6];

    string[] partyMembers = new string[3];

    bool hasSpawned = false;

	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update ()
    {
        LevelCheckandLoad();
        PartyCheck();
	}

    void PartyCheck()
    {
        if (EditorSceneManager.GetActiveScene().name != "Character Select" || partySpot[0] == null)
        {
            return;
        }

        else if (EditorSceneManager.GetActiveScene().name == "Character Select" && partySpot[0] != null)
        {
            if (partySpot[0].image.sprite != null)
            {
                partyMembers[0] = partySpot[0].image.sprite.name;
                //           Debug.Log("1st party memeber name is " + partyMembers[0]);
            }

            if (partySpot[1].image.sprite != null)
            {
                partyMembers[1] = partySpot[1].image.sprite.name;
                //            Debug.Log("2nd party memeber name is " + partyMembers[1]);
            }

            if (partySpot[2].image.sprite != null)
            {
                partyMembers[2] = partySpot[2].image.sprite.name;
                //            Debug.Log("3rd party memeber name is " + partyMembers[2]);
            }
        }
    }

    void LevelCheckandLoad()
    {
        Debug.Log("Scene name is " + EditorSceneManager.GetActiveScene().name);
        if (EditorSceneManager.GetActiveScene().name == "Character Select" && partySpot[0] != null)
        {
            return;
        }

        else if (EditorSceneManager.GetActiveScene().name == "Character Select" && partySpot[0] == null)
        {
            partyMembers[0] = null;
            partyMembers[1] = null;
            partyMembers[2] = null;

            hasSpawned = false;

            partySpot[0] = GameObject.FindGameObjectWithTag("PartyMemberButton1").GetComponent<Button>();
            partySpot[1] = GameObject.FindGameObjectWithTag("PartyMemberButton2").GetComponent<Button>();
            partySpot[2] = GameObject.FindGameObjectWithTag("PartyMemberButton3").GetComponent<Button>();
        }

        else if (EditorSceneManager.GetActiveScene().name != "Character Select" && hasSpawned == false)
        {
            if (partyMembers[0] != null)
            {
                plyrSpawnPoints[0] = GameObject.FindGameObjectWithTag("CenterSpawnPoint");

            }

            if (partyMembers[1] != null)
            {
                plyrSpawnPoints[1] = GameObject.FindGameObjectWithTag("LeftSpawnPoint");
            }

            if (partyMembers[2] != null)
            {
                plyrSpawnPoints[2] = GameObject.FindGameObjectWithTag("RightSpawnPoint");
            }

            hasSpawned = true;
        }
    }
}
