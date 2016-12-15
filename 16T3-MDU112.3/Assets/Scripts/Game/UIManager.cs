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
    public Text MaxSpeedText;

    // Display text for given UI
    public void CumlativeXP()
    {
        CumulativeXPText.text = ("Cumulative XP: " + GameManager.Instance.currentXP);
    }

    public void Level()
    {
        LevelText.text = ("Level: " + GameManager.Instance.CurrentLevel);
    }

    public void XPNextLevel()
    {
        XPNextLevelText.text = ("XP to Next Level: " + GameManager.Instance.xpToLevelUp);
    }

    public void CurrentMaxSpeed()
    {
        MaxSpeedText.text = ("Max Speed: " + PlayerController.Instance.movementSpeed);
    }
    

    void Update()
    {
        // Check the current level
        GameManager.Instance.NewCurrentLevel(GameManager.Instance.currentXP);
        GameManager.Instance.XPToNextLevel();
    }
    
}
