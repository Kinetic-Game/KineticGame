using UnityEngine;


public class CharAttributes: MonoBehaviour {

    protected float curHealth;
    public float maxHealth;
    protected float curKinetic;
    public float maxKinetic;
    public float restHamt;
    public float restKamt;
    public float attack;
    public float defense;
    private int curLevel;
    private int nextLevelAmt;
    private int lvlIncAmt;
    private int curXP;
    public string sTag;


   public void OnTriggerEnter(Collider _col)
    {
        if (_col.tag == "Enemy")
        {
            float dmg = 0f;
            AdjHealth(dmg);
        }
    }

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

    public void LevelUp()
    {
        curLevel++;
        maxHealth = maxHealth * lvlIncAmt;
        maxKinetic = maxKinetic * lvlIncAmt;
        restHamt = restHamt * lvlIncAmt;
        restKamt = restKamt * lvlIncAmt;
//Increase nextlevelAmt or reset?
    }

    public void AddXP(int _amt)
    {
        curXP += _amt;

        if (curXP >= curLevel * nextLevelAmt)
        {
            LevelUp();
        }
    }
}
