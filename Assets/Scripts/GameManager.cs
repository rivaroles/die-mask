using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dice mainDice;
    public GameObject dado1;
    public GameObject dado2;
    public GameObject dado3;
    public GameObject dado4;
    public GameObject dado5;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(mainDice.diceValue);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("This dice is locked");
        }
    }

}
