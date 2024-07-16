using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager main;
    bool hasWon = false;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI missileText;
    public float startTime;
    float currentTime;
    // Start is called before the first frame update
    void Awake()
    {
        main = this;
    }
    private void Update()
    {
        if (!hasWon)
        {
            currentTime = Time.time - startTime;
            timeText.text = "Time: " + currentTime.ToString("#.##");
        }
    }
    public void OnWinCondition()
    {
        if(!hasWon)
        {
            hasWon = true;
            winText.gameObject.SetActive(true);
            winText.text = "You caught the robbers in " + currentTime.ToString("#.##") + " seconds!";
        }
    }

    public void UpdateMissileText(string newText)
    {
        missileText.text = newText;
    }
}
