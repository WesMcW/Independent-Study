using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teet : GenericTest<int>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
