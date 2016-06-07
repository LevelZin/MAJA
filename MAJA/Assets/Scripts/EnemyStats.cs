using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class EnemyStats : BaseUnit
{
    [SerializeField]
    protected AudioClip mjau1;
    [SerializeField]
    protected AudioClip mjau2;
    [SerializeField]
    protected AudioClip mjau3;

    AudioSource audio;

    public void DoAttack()
        {
            audio = GetComponent<AudioSource>();
            Animator Kitten = GetComponent<Animator>();

            if (flee == true)
                {
                    GetComponent<AudioSource>().PlayOneShot(mjau1, 0.6F);
                    waitCommand();
                }
                else if(enemy.HP <= 0)
                {
                    GetComponent<AudioSource>().PlayOneShot(mjau3, 0.6F);
                    EnemyDie();
                }
                else
                {
                    GetComponent<AudioSource>().PlayOneShot(mjau2, 0.6F);
                    Kitten.SetTrigger("Attacking");
                    target.RecieveDamage(ability[Random.Range(0, ability.Length)].damage);
                }

                if (player.HP <= 0)
                {
                    player.PlayerDie();
                }

        }

}
