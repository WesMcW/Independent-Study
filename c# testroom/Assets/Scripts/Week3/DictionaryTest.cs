using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    Dictionary<string, int> test = new Dictionary<string, int>();

    void Start()
    {
        test.Add("Punch", 5);
        print(test["Punch"]);
        print(test["Punch"].GetType());

        test.Add("Kick", 10);
        print(test["Kick"]);
        print(test["Kick"].GetType());
    }
}
