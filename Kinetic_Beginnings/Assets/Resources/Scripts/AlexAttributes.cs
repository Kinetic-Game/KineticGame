using UnityEngine;

public class AlexAttributes : CharAttributes {

   public EnemyAttributes enemyAtt;

    public bool enemyDefeated;

    public bool isAttacking;

    public bool isDefending;

	// Use this for initialization
	void Start ()
    {
      //  curHealth = maxHealth;
      //  curKinetic = maxKinetic;
        
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   public void OnTriggerEnter(Collider _other)
    {
        if (isAttacking == true)
        {

            if (_other.tag == "Enemy")
            {
                enemyAtt.curHealth = enemyAtt.curHealth - attack;
                Debug.Log("Hit!");
                if (enemyAtt.curHealth <= 0)
                {
                    enemyDefeated = true;
                    Debug.Log("Enemy Defeated!");
                }
            }
        }
    }

    public void Defence()
    {
        enemyAtt.attack = enemyAtt.attack - defense;
    }



}
