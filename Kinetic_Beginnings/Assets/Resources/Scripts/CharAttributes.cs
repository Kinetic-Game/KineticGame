using UnityEngine;


public class CharAttributes {

    public static float curHealth;
    public static float maxHealth;
    public static float curKinetic;
    public static float maxKinetic;
    public static float restHamt;
    public static float restKamt;
    public static float defense;
    public static int curLevel;
    public static int lvlIncAmt;
    public static int curXP;


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

    public static void LevelUp()
    {
        curLevel++;
    }

    public static void AddXP(int _amt)
    {
        curXP += _amt;

        if (curXP >= curLevel * lvlIncAmt)
        {
            LevelUp();
        }
    }
}
