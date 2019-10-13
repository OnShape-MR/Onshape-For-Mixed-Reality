using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{

    public void Show(string message)
    {
        var text = this.GetComponentInChildren<TMPro.TextMeshPro>();
        if (text != null) text.text = message;

        this.gameObject.SetActive(true);

    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

}
