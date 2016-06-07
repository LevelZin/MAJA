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
            else if(enemy.HP <= 0)
            {
                EnemyDie();
            }
            else
            {
                target.RecieveDamage(ability[Random.Range(0, ability.Length)].damage);
            }

            if (player.HP <= 0)
            {
                player.PlayerDie();
            }

        }

}
