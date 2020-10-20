using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelegateTest : MonoBehaviour
{
    public delegate void SingleUse();
    public static event SingleUse single;

    public delegate void MultiUse(int num);
    public static event MultiUse multi;

    public static int myNum;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DestroyOnClick();
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (single != null)
                single();
        }
    }

    public void DestroyOnClick()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("Dude") && !hit.transform.gameObject.GetComponent<Respawn>().dead)
            {
                hit.transform.gameObject.GetComponent<Respawn>().dead = true;
            }        
        }
    }
}
