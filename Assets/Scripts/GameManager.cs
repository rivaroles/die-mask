using Unity.VisualScripting;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dice mainDice;
    public GameObject dado1;
    public GameObject dado2;
    public GameObject dado3;
    public GameObject dado4;
    public GameObject dado5;

    private int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScore(0);
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
