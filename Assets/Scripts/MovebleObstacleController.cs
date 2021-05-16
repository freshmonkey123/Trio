using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovebleObstacleController : MonoBehaviour
{
    public float speed = 0.1f;

    private CharacterController cc;
    private Vector3 move;

    private bool start = false;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        move = new Vector3(0, 0, speed * -1.0f);
    }

    void Update()
    {
        if (start)
            cc.Move(move);

        transform.position = new Vector3(transform.position.x, 0.9f, transform.position.z);
    }

    public void startMove()
    {
        start = true;
    }
}
