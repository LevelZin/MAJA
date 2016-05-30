using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    enum turn { player1, player2, player3, player4, enemy1, enemy2, enemy3, enemy4 }

    [SerializeField]
    turn currentTurn;

    bool attackDone = false;
    bool menumode = false;
    [SerializeField]
    public BaseUnit[] objList;

    [SerializeField]
    EnemyStats enemy;

    void Update()
    {
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

    }

    /*
    if (currentTurn == turn.player)
    {
        if (attackDone)
        {
            currentTurn = turn.enemy;
            attackDone = false;
        }

    }
    else
    {
        attackDone = false;
        currentTurn = turn.player;
        enemy.DoAttack();

    }

    }
*/
    public void AttackDone()
    {
        attackDone = true;

    }
}

