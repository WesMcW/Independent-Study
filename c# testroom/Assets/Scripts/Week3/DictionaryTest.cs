using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    Dictionary<string, int> test = new Dictionary<string, int>();

    void Start()
    {
        test.Add("Jump", 15);

        print(test["Jump"]);

        print(test["Jump"].GetType());
    }
}
