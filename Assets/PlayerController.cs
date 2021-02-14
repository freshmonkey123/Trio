using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 0.05f;
    public float turnInertia = 0.05f;
    public float turnSlowdown = 0.0005f;
    
    private float currentSpeed, currentTurn;
    private float modifierSlowdown;

    private CharacterController cc;
    private Vector3 move = new Vector3(0, 0, 0);

    void Start()
    {
        cc = GetComponent<CharacterController>();
        currentSpeed = speed;
        currentTurn = 0;
        modifierSlowdown = turnInertia / turnSpeed;
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        if (direction > 0.0f)
        {
            if (currentTurn < turnInertia * -1)
            {
                currentTurn += turnSpeed + turnInertia;
                currentSpeed += turnSlowdown * (-1 + modifierSlowdown);
            }
            else
            {
                currentTurn += turnSpeed;
                currentSpeed -= turnSlowdown;
            }
        }
        else if (direction < 0.0f)
        {
            if (currentTurn > turnInertia)
            {
                currentTurn -= turnSpeed + turnInertia;
                currentSpeed += turnSlowdown * (-1 + modifierSlowdown);
            }
            else
            {
                currentTurn -= turnSpeed;
                currentSpeed -= turnSlowdown;
            }
        }
        else if (currentTurn > turnInertia)
        {
            currentTurn -= turnInertia;
            currentSpeed += turnSlowdown * modifierSlowdown;
        }
        else if (currentTurn < turnInertia * -1)
        {
            currentTurn += turnInertia;
            currentSpeed += turnSlowdown * modifierSlowdown;
        }
        else
        {
            currentSpeed = speed;
            currentTurn = 0;
        }

        move.x = currentTurn * Time.deltaTime;
        move.z = currentSpeed * Time.deltaTime;

        cc.Move(move);
        transform.rotation = Quaternion.Euler(0, currentTurn * 2, 0);
    }
}
