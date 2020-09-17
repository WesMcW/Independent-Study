using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPos : MonoBehaviour
{
    public test2 c;

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Physics.Raycast(ray, out hit);

        if(hit.collider.gameObject.CompareTag("Ground") && !c.moving)
        {
            Vector3 newTarget = new Vector3(hit.point.x, 0, hit.point.z);
            c.Target = newTarget;
        }
    }
}
