using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericTest<t> : MonoBehaviour
{
    t num1;
    List<t> test = new List<t>();

    public void PrintNum()
    {
        foreach(t i in test)
        {
            Debug.Log(i);
        }
    }

    public void AddNum(t num)
    {
        test.Add(num);
    }

    public void RemoveNum(int index)
    {
        test.RemoveAt(index);
    }
}
