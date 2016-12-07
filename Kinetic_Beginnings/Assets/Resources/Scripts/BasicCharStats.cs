using UnityEngine;
using System.Collections;

public class BasicCharStats : MonoBehaviour {

	public static float curHealth;

	public static float maxHealth = 100;

	public static float curKinesis;

	public static float maxKinesis = 100;

	public static float attack = 25;

	public static float defense = 10;

	public static float rest = 10;

	public static float levelMultiplier = 1.0f;

	public static int level = 1;

    public static string tag = "PC";

    public static void AdjustHealth(int _num)
    {
        curHealth += _num;

        if (curHealth <= 0)
        {
            //Kill the Character
            Debug.Log("This character is dead.");
        }
    }
}
