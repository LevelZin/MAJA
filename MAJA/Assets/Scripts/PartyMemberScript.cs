using UnityEngine;
using System.Collections;

public class PartyMemberScript : BaseUnit{
    [SerializeField]
    UnityEngine.UI.Text[] actionButtons;

    void Awake()
    {
        for (int i = 0; i < actionButtons.Length; i++)
        {
            //actionButtons[i].text = ability[i].attack_name;
        }

    }

    public void PerformAttack(int attackNumber)
    {
        //target.RecieveDamage(ability[attackNumber].damage);
        //GameManager.AttackDone();

    }


}
