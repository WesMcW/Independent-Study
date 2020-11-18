using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    public SpriteRenderer player;

    // Start is called before the first frame update
    void Start()
    {
        var dropDown = transform.GetComponent<Dropdown>();

        dropDown.options.Clear();

        List<PlayerState> p = new List<PlayerState>();
        p.Add(PlayerState.angry);
        p.Add(PlayerState.tired);
        p.Add(PlayerState.sick);

        foreach(var state in p)
        {
            dropDown.options.Add(new Dropdown.OptionData() { text = state.ToString() });
        }

        DropdownItemSelected(dropDown);

        dropDown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropDown); });
    }

    void DropdownItemSelected(Dropdown dropDown)
    {
        int index = dropDown.value;

        switch (index)
        {
            case 0:
                GoRed();
                break;
            case 1:
                GoBlue();
                break;
            case 2:
                GoGreen();
                break;
            default:
                break;
        }
    }

    void GoBlue()
    {
        player.color = Color.blue;
    }

    void GoRed()
    {
        player.color = Color.red;
    }

    void GoGreen()
    {
        player.color = Color.green;
    }
}
