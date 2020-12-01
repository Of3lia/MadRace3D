using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float acceleration;

    [SerializeField] private Transform checkPointsContainer;
    private List<Vector3> checkPoints;
    private int currentCheckPoint;

    private void Awake()
    {
        speed = 0f;
        acceleration = 0.2f;

        checkPoints = new List<Vector3>();
        // Add Check Points to List
        for (int i = 0; i < checkPointsContainer.childCount; i++)
        {
            checkPoints.Add(checkPointsContainer.GetChild(i).transform.position);
        }
    }

    public void Move()
    {
        if (speed < 30)
        {
            speed += acceleration;
        }
        transform.position = Vector3.MoveTowards(transform.position, 
            new Vector3( checkPoints[currentCheckPoint].x, transform.position.y, checkPoints[currentCheckPoint].z), speed * Time.deltaTime);

        // Determine which direction to rotate towards
        Vector3 targetDirection = checkPoints[currentCheckPoint] - transform.position;

        // The step size is equal to speed times frame time.
        float singleStep = 1 * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 1.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    public void Stop()
    {
        speed = 0;
    }

    private void NextCheckPoint()
    {
        currentCheckPoint++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckPoint"))
        {
            if (currentCheckPoint < checkPoints.Count - 1)
            {
                NextCheckPoint();
            }
        }
    }
}
