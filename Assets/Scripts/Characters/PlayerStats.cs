using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private string playerName;

    [SerializeField] private int playerLevel = 1;
    [SerializeField] private int maxLevel = 50;
    [SerializeField] private int currentXP;
    [SerializeField] private int[] xpForEachLevel;
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
        xpForEachLevel = new int[maxLevel];
        for (int i = 1; i < xpForEachLevel.Length; i++)
        {
            xpForEachLevel[i] = (int)(0.02f * i * i * i + 3.06 * i * i + 105.6f * i);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}