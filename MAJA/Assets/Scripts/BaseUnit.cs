using UnityEngine;
using System.Collections;

public class BaseUnit : MonoBehaviour
{

    [SerializeField]
    [Range(0, 100)]
    protected int m_health = 100;

    [SerializeField]
    private RectTransform healthbar;

    [SerializeField]
    protected BaseUnit target;

        //Resistances and Weaknesses
        [SerializeField]
        [Range(-5, 5)]
        protected float SlashVulnerability = 1;

        [SerializeField]
        [Range(-5, 5)]
        protected float BashVulnerability = 1;
    
        [SerializeField]
        [Range(-5, 5)]
        protected float FireVulnerability = 1;
    
        [SerializeField]
        [Range(-5, 5)]
        protected float IceVulnerability = 1;

        [SerializeField]
        [Range(-5, 5)]
        protected float ThunderVulnerability = 1;

        [SerializeField]
        [Range(-5, 5)]
        protected float EarthVulnerability = 1;

        [SerializeField]
        [Range(-5, 5)]
        protected float ForceVulnerability = 1;

        [SerializeField]
        [Range(-5, 5)]
        protected float MysticVulnerability = 1;



    [SerializeField]
    protected GameManager gameManager;

    [System.Serializable]
    public class abilities
    {
        public string attack_name;
        public int damage;
    }

    [SerializeField]
    UnityEngine.UI.Text feedbackText;


    void Update()
    {
        healthbar.sizeDelta = new Vector2(m_health * 4.9f, 30.0f);
    }

    public void RecieveDamage(int damage)
    {
        feedbackText.text += "\n The target took " + damage + " dmg";

        m_health -= damage;

    }

    [SerializeField]
    protected abilities[] abilitie;

}
