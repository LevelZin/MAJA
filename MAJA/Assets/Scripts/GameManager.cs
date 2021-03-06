﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class GameManager : MonoBehaviour
{
    enum turn { player, enemy, none }

    [SerializeField]
    turn currentTurn;

    bool attackDone = false;
    bool menumode = false;
    [SerializeField]
    public BaseUnit[] objList;

    [SerializeField]
    EnemyStats enemy;

    [SerializeField]
    float delay;

    [SerializeField]
    GameObject battleCanvas;

    [SerializeField]
    protected AudioClip mjau;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        battleCanvas.GetComponent<Canvas>().enabled = true;
    }

    //void Update()
    //{
    //    while (true) //While loop 1
    //    {
    //        while (true) //While loop 2
    //        {
    //            menumode = true;
    //            if (BaseUnit.cReady == true)
    //            {
    //                int highestNr = 0;
    //                int highestNrIndex = 0;
    //                //selectMostInitPawn;
    //                    for(int i=0;i<objList.Length;i++)
    //                    {
    //                        int j = objList[i].initiative;

    //                        if (j > highestNr)
    //                        {
    //                            highestNr = j;
    //                            highestNrIndex = i;
    //                        }
    //                    }

    //                objList[highestNrIndex].combatMenu();
                    
    //            }
    //            else
    //            {
    //                break; //Break For loop
    //            }
    //        } //End of While loop 2
            
    //        if (numEnemies == 0)
    //        {
    //            combatResult = victory;
    //            break; //Break While loop
    //        }
    //        if (numAliveAllies == 0)
    //        {
    //            combatResult = defeat;
    //            break; //Break While loop
    //        }

    //        allpawn.selectedPawnInit = allpawn.selectedPawnInit + pawnStatSpeed;
    //        tickAll();
            
    //    }//End of While loop 1
        
    //}

    //void tickAll ()
    //{

    //}

    void Update()
    {
        
        if (currentTurn == turn.player)
        {
            //Debug.Log("Player Turn.");
            if (attackDone)
            {
                GetComponent<AudioSource>().PlayOneShot(mjau, 0.6F);
                Debug.Log("Enemy Turn.");
                currentTurn = turn.enemy;
                attackDone = false;
            }

        }
        //else if (flee == true)
        //{
        //    currentTurn == turn.none;
        //}
        else
        {
            battleCanvas.GetComponent<Canvas>().enabled = false;
            Debug.Log("Enemy is Attacking!");
            attackDone = false;
            StartCoroutine(StartDelay(2.0f));
            currentTurn = turn.player;
        }

    }

    public void AttackDone()
    {
        attackDone = true;
    }

    IEnumerator StartDelay(float duration)
    {
        duration = delay;
        yield return new WaitForSeconds(duration);   //Wait
        enemy.DoAttack();
        battleCanvas.GetComponent<Canvas>().enabled = true;
    }

}

