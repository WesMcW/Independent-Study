using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int num = 0;
    public Text numText;


    private void Awake()
    {
        Minions.MinionAlive += AddOne;
        Minions.MinionDead += SubOne;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DestroyOnClick();
        }

        numText.text = num.ToString();
    }

    public void AddOne()
    {
        num++;
    }

    public void SubOne()
    {
        num--;
    }

    public void DestroyOnClick()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("Dude"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
