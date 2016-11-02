using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditor.SceneManagement;

public class FightSelectSpawn : MonoBehaviour {

    int level;
    public GameObject[] lvlPrefabs;
    bool lvlSpawned = false;

	// Use this for initialization
	void Start () {
	
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
            return;
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
