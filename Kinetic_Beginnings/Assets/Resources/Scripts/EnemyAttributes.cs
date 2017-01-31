using UnityEngine;

public class EnemyAttributes : MonoBehaviour {

    public AlexAttributes alexAtt;

    public bool enemyAttacking;

    public float curHealth;
    public float maxHealth;
    public float curKinetic;
    public float maxKinetic;
    public float restHamt;
    public float restKamt;
    public float attack;
    public float defense;
    public string sTag = "Enemy";


    public void OnTriggerEnter (Collider _other)
    {
        if (enemyAttacking == true)
        {
            if (alexAtt.isDefending == true && _other.tag == "Player")
            {
                float tempAttack = attack - alexAtt.defense;
                //attack =  attack - alexAtt.defense;

                alexAtt.curHealth = curHealth - tempAttack;
            }

            if (_other.tag == "Player" && alexAtt.isDefending == false)
            {
                alexAtt.curHealth = curHealth - attack;
            }
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
}
