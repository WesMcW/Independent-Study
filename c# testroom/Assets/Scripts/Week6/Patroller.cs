using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public Transform pointA, pointB;
    public float speed;

    bool goA, goB;


    void Start()
    {
        goA = true;
    }

    void Update()
    {
        if (goA)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
            if (transform.position == pointA.position)
            {
                goB = true;
                goA = false;
            }
        }
        else if (goB)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
            if (transform.position == pointB.position)
            {
                goA = true;
                goB = false;
            }
        }

    }
}
