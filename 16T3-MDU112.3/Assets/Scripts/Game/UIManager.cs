using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
	
    void Awake()
    {
        Instance = this;
    }

    public Text CumulativeXPText;
    public Text LevelText;
    public Text XPNextLevelText;

    public void CumlativeXP()
    {
        int newCumlativeXP = 0;
        GameManager.Instance.currentXP = newCumlativeXP;
        CumulativeXPText.text = ("Cumulative XP: " + newCumlativeXP);
    }

    public void Level()
    {
        int CurrentLevel = 0;
        GameManager.Instance.CurrentLevel = CurrentLevel;
        LevelText.text = ("Level: " + CurrentLevel);
    }

    public void XPNextLevel()
    {
        int newXPToLevelUp = 0;
        GameManager.Instance.xpToLevelUp = newXPToLevelUp;
        XPNextLevelText.text = ("XP to Next Level: " + newXPToLevelUp);
    }

}
