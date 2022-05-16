using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
using UnityEngine.SceneManagement;

public class LevelOptionHandler : MonoBehaviour
{
    public List<string> options = new List<string> {
        "Option A"
    };
    public int value = 0;

    // Start is called before the first frame update
    void Start()
    {
        var dropdown = GetComponent<TMP_Dropdown>();

        dropdown.options.Clear();

        // Fill the level options
        foreach(var option in options)
        {
            dropdown.options.Add(
                new TMP_Dropdown.OptionData { text = option }
            );
        }
        dropdown.value = 0;

        dropdown.onValueChanged.AddListener(delegate { onDropDownValueChanged(dropdown); });

    }

    void onDropDownValueChanged(TMP_Dropdown dropdown)
    {
        SceneManager.LoadScene(dropdown.value);
    }

}
