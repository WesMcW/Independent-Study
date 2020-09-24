using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericTest<T> : MonoBehaviour
{
    List<T> test = new List<T>();

    public void PrintNum()
    {
        foreach(T i in test)
        {
            Debug.Log(i);
        }
    }

    public void AddNum(T num)
    {
        test.Add(num);
    }

    public void RemoveNum(int index)
    {
        test.RemoveAt(index);
    }
}
