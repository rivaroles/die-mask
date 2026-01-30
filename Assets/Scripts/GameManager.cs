using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _prefabDice;

    void Start()
    {
        
    }

    private void InitializeDice()
    {
        for (int i = 0; i < 5; i++)
        {
            var die = new Dice(6);

            var result = die.RollDice();

            GameObject obj = Instantiate(_prefabDice);
            obj.transform.position = new Vector3(0, 0, 0);

            Debug.Log(result);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            InitializeDice();
        }
    }

}
