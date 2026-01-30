using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _prefabDice;
    public Vector3 _instantiatePosition;
    public GameObject _instantiator;
    public int _result;

    void Start()
    {
        _instantiatePosition.Equals(_instantiator.transform.localPosition);

    }

    /*public void InitializeDice()
    {
        for (int i = 0; i < 5; i++)
        {
            var die = new Dice(6);

            _result = die.RollDice();

            Debug.Log(_result);
        }
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            //InitializeDice();
            //RollCheck();
        }
    }*/

}
