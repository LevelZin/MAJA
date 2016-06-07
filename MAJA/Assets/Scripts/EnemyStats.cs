using UnityEngine;
using System.Collections;

public class EnemyStats : BaseUnit
{
    //flee = false;

        public void DoAttack()
        {
            target.RecieveDamage(ability[Random.Range(0, ability.Length)].damage);

        }

}
