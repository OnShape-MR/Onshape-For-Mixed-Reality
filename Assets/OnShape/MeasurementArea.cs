using System;
using System.Collections;
using System.Collections.Generic;
using IO.Swagger.Model;
using UnityEngine;

public class MeasurementArea : MonoBehaviour
{

    private TMPro.TextMeshPro _textMesh;

    void Start()
    {
        _textMesh= GetComponentInChildren<TMPro.TextMeshPro>();
    }

    public void SetText(PartStudiosGetBodyDetailsResponse200Faces details)
    {
        if (details == null)
        {
            _textMesh.text = "";
        }
        else
        {
            _textMesh.text = details.Surface.Type + "\n" + ((float)details.Area).ToString("0.0000") + "m²";
        }
    }
}
