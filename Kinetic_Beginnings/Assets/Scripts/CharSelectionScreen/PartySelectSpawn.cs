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
        DelCopies();
        LevelCheckandLoad();
        PartyCheck();
	}

    void DelCopies()
    {
        PartySelectSpawn[] obj;
        obj = GameObject.FindObjectsOfType<PartySelectSpawn>();
        if (obj.Length > 1)
        {
            for (int i = 1; i < obj.Length; i++)
            {
                Destroy(obj[i].gameObject);
            }
            
        }
    }

    void PartyCheck()
    {
        if (EditorSceneManager.GetActiveScene().name != "Character Select" || partySpot[0] == null)
        {
            return;
        }

        if (EditorSceneManager.GetActiveScene().name == "Character Select" && partySpot[0] != null)
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
        if (EditorSceneManager.GetActiveScene().name == "Character Select")
        {
            if (partySpot[0] != null)
            {
                return;
            }

            if (partySpot[0] == null)
            {
                partyMembers[0] = null;
                partyMembers[1] = null;
                partyMembers[2] = null;

                hasSpawned = false;

                partySpot[0] = GameObject.FindGameObjectWithTag("PartyMemberButton1").GetComponent<Button>();
                partySpot[1] = GameObject.FindGameObjectWithTag("PartyMemberButton2").GetComponent<Button>();
                partySpot[2] = GameObject.FindGameObjectWithTag("PartyMemberButton3").GetComponent<Button>();
            }
        }


        if (EditorSceneManager.GetActiveScene().name != "Character Select")
        {
            if (hasSpawned == true)
            {
                return;
            }

            if (hasSpawned == false)
            {
                if (partyMembers[0] != null)
                {
                    if (partyMembers[0] != null)
                    {
                        plyrSpawnPoints[0] = GameObject.FindGameObjectWithTag("LeftSpawnPoint");
                        Instantiate(plyrPrefabs[0], plyrSpawnPoints[0].transform);
                    }

                    if (partyMembers[1] != null)
                    {
                        plyrSpawnPoints[1] = GameObject.FindGameObjectWithTag("CenterSpawnPoint");
                        Instantiate(plyrPrefabs[0], plyrSpawnPoints[1].transform);
                    }

                    if (partyMembers[2] != null)
                    {
                        plyrSpawnPoints[2] = GameObject.FindGameObjectWithTag("RightSpawnPoint");
                        Instantiate(plyrPrefabs[0], plyrSpawnPoints[2].transform);
                    }
                }

                hasSpawned = true;
            }
        }
    }
}
