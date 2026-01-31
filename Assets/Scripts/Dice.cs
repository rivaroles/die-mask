using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
    
public class Dice : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private Vector3 initPosition;
    private Transform myDice;

    private GameManager gameManager;

    public int diceValue;
    public int rollResult;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        initPosition = transform.position;
        _rigidBody.useGravity = false;
        myDice = this.transform;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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

    public void RollDice()
    {
        diceValue = UnityEngine.Random.Range(1, 7);
        switch (diceValue)
        {
            case 1:
                myDice.localRotation = Quaternion.Euler(180, 0, 0);
                rollResult = 1;
                //gameManager.UpdateScore(rollResult);
                break;
            case 2:
                myDice.localRotation = Quaternion.Euler(90, 0, 0);
                rollResult = 2;
                break;
            case 3:
                myDice.localRotation = Quaternion.Euler(0, 0, 90);
                rollResult = 3;
                break;
            case 4:
                myDice.localRotation = Quaternion.Euler(0, 0, -90);
                rollResult = 4;
                break;
            case 5:
                myDice.localRotation = Quaternion.Euler(-90, 0, 0);
                rollResult = 5;
                break;
            case 6:
                myDice.localRotation = Quaternion.Euler(0, 0, 0);
                rollResult = 6;
                break;
            default:
                myDice.localRotation = Quaternion.Euler(45, 45, 45);
                rollResult = 0;
                break;
        }
        _rigidBody.useGravity = true;
    }

    private void ResetDice()
    {
        this.transform.position = initPosition;
        _rigidBody.useGravity = false;
    }

}
