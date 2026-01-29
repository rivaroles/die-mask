using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class DiceRoll : MonoBehaviour
{
    Rigidbody myRb;

    [SerializeField] private float maxRandomForce, startRollingForce;

    private float forceX, forceY, forceZ;

    public int diceFaceNum;

    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        if (myRb != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RollDice();
            }
        }
    }

    private void RollDice()
    {
        myRb.isKinematic = false;

        forceX = Random.Range(0, maxRandomForce);
        forceY = Random.Range(0, maxRandomForce);
        forceZ = Random.Range(0, maxRandomForce);

        myRb.AddForce(Vector3.up * startRollingForce);
        myRb.AddTorque(forceX, forceY, forceZ);
    }

    private void Initialize()
    {
        myRb = GetComponent<Rigidbody>();
        myRb.isKinematic = true;
        transform.rotation = new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0);   
    }
}
