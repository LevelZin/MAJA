using UnityEngine;
using System.Collections;
using namespace std;

public class GameManager : MonoBehaviour
{
    enum turn { player1, player2, player3, player4, enemy1, enemy2, enemy3, enemy4 }

    [SerializeField]
    turn currentTurn;

    bool attackDone = false;
    bool menumode = false;
    [SerializeField]
    public GameObject[] objList;

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
                    GameObject sadf;
                    //selectMostInitPawn;
                    foreach (GameObject unit in objList)
                        {
                        int i = unit.GetComponent<BaseUnit>().initiative;

                        if(i > highestNr)
                        {
                            highestNr = i;
                            sadf = unit;
                        }

                        sadf.GetComponent<combatMenu>();
                    }


                    
                    If(menumode == false)
                    {
                        sadf = sadf - 1000;
                    }
                }
                else
                {
                    break;
                }
            }
            if(numEnemies == 0){
                combatResult = victory;
                break;
            }
            if(numAliveAllies == 0){
                combatResult = defeat;
                break;
            }
            allpawn.selectedPawnInit = allpawn.selectedPawnInit + pawnStatSpeed;
            tickAll();
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

