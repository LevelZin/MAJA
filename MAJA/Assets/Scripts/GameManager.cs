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
        while (true)
        {
            while (true)
            {
                menumode = true;
                if (BaseUnit.cReady == true)
                {
                    int highestNr = 0;
                    int highestNrIndex = 0;
                    //selectMostInitPawn;
                    for(int i=0;i<objList.Length;i++)
                    {
                        int j = objList[i].initiative;

                        if (j > highestNr)
                        {
                            highestNr = j;
                            highestNrIndex = i;
                        }
                    }

                    objList[highestNrIndex].combatMenu();
                    
                }
                else
                {
                    break;
                }
            }
            /*
            if (numEnemies == 0)
            {
                combatResult = victory;
                break;
            }
            if (numAliveAllies == 0)
            {
                combatResult = defeat;
                break;
            }
            allpawn.selectedPawnInit = allpawn.selectedPawnInit + pawnStatSpeed;
            tickAll();
            */
        }




    }

    void tickAll ()
    {

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

    public void AttackDone()
    {
        attackDone = true;

    }*/
}

