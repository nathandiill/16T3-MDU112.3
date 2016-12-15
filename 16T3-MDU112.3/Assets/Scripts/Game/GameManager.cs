using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int CurrentLevel;
    public int xpToLevelUp;
    public int currentXP;
    public int XPNeeded;

    void Awake()
    {
        Instance = this;
    }

    // Add XP from given sources
    public void CurrentXP(int increasedXP)
    {
        currentXP = currentXP + increasedXP;
    }

    // Detect if the player has levelled up
    public int NewCurrentLevel(int CurrentXP)
    {
        if (CurrentXP == 0)
        {
            return CurrentLevel = 0;
        }
        else if (CurrentXP == 1)
        {
            return CurrentLevel = 1;
        }
        else if (CurrentXP >= 2 && CurrentXP <= 4)
        {
            return CurrentLevel = 2;
        }

        else if (CurrentXP >= 5 && CurrentXP <= 9)
        {
            return CurrentLevel = 3;
        }
        else if (CurrentXP >= 10 && CurrentXP <= 16)
        {
            return CurrentLevel = 4;
        }
        else if (CurrentXP >= 17 && CurrentXP <= 25)
        {
            return CurrentLevel = 5;
        }
        else if (CurrentXP >= 26 && CurrentXP <= 36)
        {
            return CurrentLevel = 6;
        }
        else if (CurrentXP >= 37 && CurrentXP <= 49)
        {
            return CurrentLevel = 7;
        }
        else if (CurrentXP >= 50 && CurrentXP <= 64)
        {
            return CurrentLevel = 8;
        }
        else if (CurrentXP >= 65 && CurrentXP <= 81)
        {
            return CurrentLevel = 9;
        }
        else if (CurrentXP >= 82)
        {
            return CurrentLevel = 10;
        }

        return CurrentLevel = 10;

    }

    public void XPToNextLevel()
    {
        XPNeeded = CurrentLevel * CurrentLevel;
        xpToLevelUp = XPNeeded - currentXP;
    }

    void Update()
    {
        UIManager.Instance.CumlativeXP();
        UIManager.Instance.Level();
        UIManager.Instance.XPNextLevel();
        UIManager.Instance.CurrentMaxSpeed();
        PlayerController.Instance.levelUpBonus();
    }
}