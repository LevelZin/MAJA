using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    enum turn { player, player2, player3, player4, enemy, enemy2, enemy3, enemy4 }

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

    void Start()
    {
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
            if (attackDone)
            {
                Debug.Log("Enemy Turn.");
                currentTurn = turn.enemy;
                attackDone = false;
            }

        }
        else
        {
            battleCanvas.GetComponent<Canvas>().enabled = false;
            Debug.Log("Enemy is Attacking!");
            attackDone = false;
            StartCoroutine(StartDelay(5.0f));
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

