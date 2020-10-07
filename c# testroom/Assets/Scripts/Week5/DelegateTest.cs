using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelegateTest : MonoBehaviour
{
    public delegate void SingleUse();
    SingleUse single;
    public static event SingleUse Single;

    public int myNum;

    private void Start()
    {
        Single += CountUp;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Single != null)
            {
                CountUp();
            }
        }
    }

    public void CountUp()
    {
        myNum++;
        print(myNum);
    }
}
