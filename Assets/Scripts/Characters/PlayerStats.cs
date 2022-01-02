using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private string playerName;

    [SerializeField] private int playerLevel = 1;
    [SerializeField] private int maxLevel = 50;
    [SerializeField] private int currentXP;
    [SerializeField] private int[] xpForNextLevel;
    [SerializeField] private int baseLevelXP = 100;

    [SerializeField] private int currentHP;
    [SerializeField] private int maxHP;

    [SerializeField] private int currentMP;
    [SerializeField] private int maxMP;

    [SerializeField] private int attack;
    [SerializeField] private int defence;
    [SerializeField] private int dexterity;
    [SerializeField] private int intelligence;

    // Start is called before the first frame update
    private void Start()
    {
        xpForNextLevel = new int[maxLevel];
        for (int i = 1; i < xpForNextLevel.Length; i++)
        {
            xpForNextLevel[i] = (int)(0.02f * i * i * i + 3.06 * i * i + 105.6f * i);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddXP(baseLevelXP);
        }
    }

    public void AddXP(int amount)
    {
        currentXP += amount;
        if (currentXP > xpForNextLevel[playerLevel])
        {
            currentXP -= xpForNextLevel[playerLevel];
            playerLevel++;

            maxHP = Mathf.FloorToInt(maxHP * 1.18f);
            currentHP = maxHP;

            maxMP = Mathf.FloorToInt(maxMP * 1.06f);
            currentMP = maxMP;

            if (playerLevel % 2 == 0)
            {
                dexterity++;
            }
            else
            {
                defence++;
            }
        }
    }
}