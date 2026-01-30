using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 initPosition;
    private Transform myDice;


    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        initPosition = transform.position;
        rigidbody.useGravity = false;
        myDice = this.transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ResetDice();
        }
    }

    /*public Dice(int numberOfSides)
    {
        _numberOfSides = numberOfSides;
    }*/

    private void RollDice()
    {
        int diceValue = UnityEngine.Random.Range(1, 7);
        Debug.Log(diceValue);
        switch (diceValue)
        {
            case 1:
                myDice.localRotation = Quaternion.Euler(180, 0, 0);
                break;
            case 2:
                myDice.localRotation = Quaternion.Euler(-90, 0, 0);
                break;
            case 3:
                myDice.localRotation = Quaternion.Euler(0, 0, 0);
                break;
            case 4:
                myDice.localRotation = Quaternion.Euler(90, 0, 0);
                break;
            case 5:
                myDice.localRotation = Quaternion.Euler(0, 0, 90);
                break;
            case 6:
                myDice.localRotation = Quaternion.Euler(0, 0, -90);
                break;
            default:
                myDice.localRotation = Quaternion.Euler(45, 45, 45);
                break;
        }
        rigidbody.useGravity = true;
    }

    private void ResetDice()
    {
        this.transform.position = initPosition;
        rigidbody.useGravity = false;
    }

}
