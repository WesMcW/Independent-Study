using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : GenericTest<int>
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PrintNum();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            AddNum(4);
            AddNum(6);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RemoveNum(1);
        }
    }
}
