using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{

    public void Show(string message)
    {
        transform.position = Camera.main.transform.position + new Vector3(0, 0, 1);

        var text = this.GetComponentInChildren<TMPro.TextMeshPro>();
        if (text != null) text.text = message;

        this.gameObject.SetActive(true);

    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

}
