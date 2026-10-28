using UnityEngine;

public class UpgradePurchase : MonoBehaviour
{
    private int count = 0;
    public int gold = 500;
    public int costPerLevel = 20;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            count++;

            if (count == 5)
            {
                for (int level = 5; level >= 1; level--)
                {
                    int cost = costPerLevel * level;
                    int goldLeft = gold - cost;
                    Debug.Log($"{level}... cost {cost}");
                    Debug.Log($"{goldLeft} left");
                }

                Debug.Log("Upgrade complete!");
                count = 0;
            }
        }
    }
}