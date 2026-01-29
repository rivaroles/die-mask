using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    DiceRoll dice;

    [SerializeField]
    Text scoreText;

    private void Awake()
    {
        dice = FindAnyObjectByType<DiceRoll>();
    }

    private void Update()
    {
        if (dice != null)
        {
            if (dice.diceFaceNum != 0)
            {
                scoreText.text = dice.diceFaceNum.ToString();
            }
        }
    }
}
