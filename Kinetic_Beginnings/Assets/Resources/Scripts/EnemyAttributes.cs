using UnityEngine;

public class EnemyAttributes : MonoBehaviour {

    public static float curHealth;
    public static float maxHealth;
    public static float curKinetic;
    public static float maxKinetic;
    public static float restHamt;
    public static float restKamt;
    public static float attack;
    public static float defense;
    public static string tag = "Enemy";

    public static void AdjHealth(float _amt)
    {
        if (_amt < 0)
        {
            float temp = _amt + defense;
            if (temp >= 0)
            {
                return;
            }
            else
            {
                curHealth += temp;
            }
        }
        else
        {
            curHealth += _amt;
        }

    }

    public static void Rest()
    {
        curHealth += restHamt;
        curKinetic += restKamt;
    }
}
