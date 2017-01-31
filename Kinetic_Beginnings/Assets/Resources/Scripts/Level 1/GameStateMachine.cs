using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GameStateMachine : MonoBehaviour {

    public MainUIFunction UIPresses;

    private Dictionary<GameStates, Action> GSD = new Dictionary<GameStates, Action>();

    public GameStates curState;

    public GameStates previousState;

    public AlexAttributes alexAtt;

    public EnemyAttributes enemyAtt;

    public enum GameStates
    {
        EnterGame,
        PlayerTurn,
        EnemyTurn,
        End,

       // NUM_STATES
    }

    public float EnemyTime = 0;


    public void SetState (GameStates newState)
    {
        curState = newState;
    }

    // Use this for initialization
    void Start ()
    {
        GSD.Add(GameStates.EnterGame, new Action(StateEnter));
        GSD.Add(GameStates.PlayerTurn, new Action(StatePlayer));
        GSD.Add(GameStates.EnemyTurn, new Action(StateEnemy));
        GSD.Add(GameStates.End, new Action(StateEnd));

        SetState(GameStates.PlayerTurn);
    }
	
	// Update is called once per frame
	void Update ()
    {
        GSD[curState].Invoke();	
	}

     void StateEnter ()
    {
        Debug.Log("StateEnter");

        SetState(GameStates.PlayerTurn);
    }

     void StatePlayer()
    {
        Debug.Log("Player Turn");

        if (UIPresses.attackPressed == true)
        {
            alexAtt.isAttacking = true;

            //play attack animation

          //  Debug.Log("UI Was Pressed");

         //   if (alexAtt.enemyDefeated == true)
          //  {
        //        SetState(GameStates.End);
          //  }

            if (UIPresses.defendPressed == true)
            {
                //play defend animation

                alexAtt.isDefending = true;
                SetState(GameStates.EnemyTurn);
            }

            SetState (GameStates.EnemyTurn);

           
        }
    }

     void StateEnemy()
    {
        EnemyTime += Time.deltaTime;

        Debug.Log("EnemyTurn");

        if (EnemyTime >= 10)
        {
            //play animation

            enemyAtt.enemyAttacking = true;

            if(alexAtt.isDefending == true)
            {

            }

            SetState(GameStates.End);

            EnemyTime = 0;
        }
    }

     void StateEnd()
    {
        Debug.Log("StateEnd of Round");
    }
}
