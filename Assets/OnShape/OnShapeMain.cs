using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnShapeMain : MonoBehaviour
{
    public GameObject StartPanel;

    public MenuDocument MenuDocument;



    // Start is called before the first frame update
    void Start()
    {
        StartPanel.SetActive(true);
        MenuDocument.gameObject.SetActive(false);
    }

    public void AfterConnect()
    {



    }

    public void OpenDocument(string id)
    {



    }

}
