using UnityEngine;

public class EnemyAttributes : MonoBehaviour {

    public float curHealth;
    public float maxHealth;
    public float curKinetic;
    public float maxKinetic;
    public float restHamt;
    public float restKamt;
    public float attack;
    public float defense;
    public string sTag = "Enemy";

    public void AdjHealth(float _amt)
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

    public void Rest()
    {
        curHealth += restHamt;
        curKinetic += restKamt;
    }
}
