﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.SceneManagement;

public class PartySelectSpawn : MonoBehaviour {

    public Button[] partySpot = new Button[3];

    public GameObject[] plyrSpawnPoints = new GameObject[3];

    public GameObject[] plyrPrefabs = new GameObject[6];

    string[] partyMembers = new string[3];

    bool hasSpawned = false;

    int memNumber;

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
//                Debug.Log("1st party memeber name is " + partyMembers[0]);
            }

            if (partySpot[1].image.sprite != null)
            {
                partyMembers[1] = partySpot[1].image.sprite.name;
//                Debug.Log("2nd party memeber name is " + partyMembers[1]);
            }

            if (partySpot[2].image.sprite != null)
            {
                partyMembers[2] = partySpot[2].image.sprite.name;
//                Debug.Log("3rd party memeber name is " + partyMembers[2]);
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
                    if (partyMembers[2] != null)
                    {
                        plyrSpawnPoints[2] = GameObject.FindGameObjectWithTag("LeftSpawnPoint");
                        SpwnWhichMember();
                        Instantiate(plyrPrefabs[memNumber], plyrSpawnPoints[2].transform.position, plyrSpawnPoints[2].transform.rotation);
                    }

                    if (partyMembers[1] != null)
                    {
                        plyrSpawnPoints[1] = GameObject.FindGameObjectWithTag("CenterSpawnPoint");
                        SpwnWhichMember();
                        Instantiate(plyrPrefabs[memNumber], plyrSpawnPoints[1].transform.position, plyrSpawnPoints[1].transform.rotation);
                    }

                    if (partyMembers[0] != null)
                    {
                        plyrSpawnPoints[0] = GameObject.FindGameObjectWithTag("RightSpawnPoint");
                        SpwnWhichMember();
                        Instantiate(plyrPrefabs[memNumber], plyrSpawnPoints[0].transform.position, plyrSpawnPoints[0].transform.rotation);
                    }
                }

                hasSpawned = true;
            }
        }
    }

    void SpwnWhichMember()
    {
        int pos;
        if (ArrayUtility.Contains(partyMembers, "Alex_Char_Select"))
        {
            pos = ArrayUtility.IndexOf(partyMembers, "Alex_Char_Select");
            memNumber = 0;
            ArrayUtility.RemoveAt(ref partyMembers, pos);
        }

        else if (ArrayUtility.Contains(partyMembers, "D_Char_Select"))
        {
            pos = ArrayUtility.IndexOf(partyMembers, "D_Char_Select");
            memNumber = 1;
            ArrayUtility.RemoveAt(ref partyMembers, pos);
        }

        else if (ArrayUtility.Contains(partyMembers, "Cass_Char_Select"))
        {
            pos = ArrayUtility.IndexOf(partyMembers, "Cass_Char_Select");
            memNumber = 2;
            ArrayUtility.RemoveAt(ref partyMembers, pos);
        }

        else if (ArrayUtility.Contains(partyMembers, "Chris_Char_Select"))
        {
            pos = ArrayUtility.IndexOf(partyMembers, "Chris_Char_Select");
            memNumber = 3;
            ArrayUtility.RemoveAt(ref partyMembers, pos);
        }

        else if (ArrayUtility.Contains(partyMembers, "Tori_Char_Select"))
        {
            pos = ArrayUtility.IndexOf(partyMembers, "Tori_Char_Select");
            memNumber = 4;
            ArrayUtility.RemoveAt(ref partyMembers, pos);
        }

        else if (ArrayUtility.Contains(partyMembers, "Shyra_Char_Select"))
        {
            pos = ArrayUtility.IndexOf(partyMembers, "Shyra_Char_Select");
            memNumber = 5;
            ArrayUtility.RemoveAt(ref partyMembers, pos);
        }
    }


}
