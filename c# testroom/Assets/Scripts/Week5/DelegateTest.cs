using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelegateTest : MonoBehaviour
{
    public delegate void SingleUse();
    SingleUse single;

    public delegate void MultiUse();
    public static event MultiUse multi;

    public int myNum;

    private void Start()
    {
        multi += DestroyOnClick;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DestroyOnClick();
        }
    }

    public void DestroyOnClick()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("Dude"))
            {
                if (multi != null)
                {
                    CountUp();
                    hit.transform.gameObject.GetComponent<Respawn>().dead = true;
                }
            }        
        }
    }

    public void CountUp()
    {
        myNum++;
        print(myNum);
    }
}
