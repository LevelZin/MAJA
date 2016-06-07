using UnityEngine;
using System.Collections;

public class EnemyStats : BaseUnit
{
    
        public void DoAttack()
        {
            if(flee == true)
            {
                waitCommand();
            }
            else if(HP <= 0)
            {
                EnemyDie();
            }
            else
            {
                target.RecieveDamage(ability[Random.Range(0, ability.Length)].damage);
            }
            
        }

}
