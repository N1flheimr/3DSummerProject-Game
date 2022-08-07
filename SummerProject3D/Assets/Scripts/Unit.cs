using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition_;
    [SerializeField] private float moveSpeed = 4f;

    private void Update()
    {
        Vector3 toTarget = targetPosition_ - transform.position;
        float dist = toTarget.magnitude;

        if (dist > 0)
        {
            Vector3 move = toTarget.normalized * moveSpeed * Time.deltaTime;

            if (move.magnitude > dist)
            {
                move = toTarget;
            }
            transform.position += move;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Move(new Vector3(4f, 0, 4f));
        }
    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPosition_ = targetPosition;
    }
}
