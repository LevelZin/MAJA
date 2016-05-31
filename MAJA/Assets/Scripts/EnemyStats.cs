using UnityEngine;
using System.Collections;

public class EnemyStats : BaseUnit
{

    public void DoAttack()
    {

        target.RecieveDamage(ability[Random.Range(0, ability.Length)].damage);

    }

}
