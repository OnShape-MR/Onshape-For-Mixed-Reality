using IO.Swagger.Model;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System;

public class MenuDocument : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DocumentPrefab;
    public GameObject ContentContainer;
    private GameObject _currentgo;
    private TextMeshProUGUI _textcomp;
    private Image _imagethumbnail;
    public Sprite Imagetoshow;
    private Button _currentbutton;

    public OnShapeMain Main;

    void Start()
    {
        ////var _json = Resources.Load<TextAsset>("documents");
        ////RefreshDocumentList(JsonConvert.DeserializeObject<DocumentsGetDocumentsResponse200>(_json.text));
        //var _json2 = Resources.Load<TextAsset>("elements");

      
        //    var ob = JsonConvert.DeserializeObject<DocumentsGetElementListResponse200>(_json2.text);
        //RefreshTabList(ob);


    }
    public void  RefreshDocumentList(DocumentsGetDocumentsResponse200 List)
    {
        transform.position = Camera.main.transform.position + new Vector3(0, 0, 1);
        gameObject.SetActive(true);

        foreach (Transform child in ContentContainer.transform) { Destroy(child.gameObject); };

        foreach (DocumentsGetDocumentsResponse200Items _currentitem  in List.Items)
        {
            _currentgo= Instantiate(DocumentPrefab,ContentContainer.transform);
            _textcomp = _currentgo.GetComponentInChildren<TextMeshProUGUI>();
            _textcomp.text = "Document Name : " + _currentitem.Name + "\nLast modified by : " + _currentitem.ModifiedBy.Name + " on " + _currentitem.ModifiedAt + "\nOwned by : " + _currentitem.Owner.Name;
            _currentbutton = _currentgo.GetComponentInChildren<Button>();
            _imagethumbnail = _currentgo.GetComponentInChildren<Image>();
            _imagethumbnail.sprite = _currentitem.Thumbnail.Image;
            _currentbutton.onClick.AddListener(() =>
            {
                Main.OpenDocument(_currentitem);
            });
        }
    }
    public void RefreshTabList(DocumentsGetElementListResponse200 List, DocumentsGetElementListResponse200Elements selectedElement)
    {
        transform.position = Camera.main.transform.position + new Vector3(0, 0, 1);
        gameObject.SetActive(true);

        foreach (Transform child in ContentContainer.transform) { Destroy(child.gameObject); };
        
        foreach (DocumentsGetElementListResponse200Elements _currentitem in List)
        {
            _currentgo = Instantiate(DocumentPrefab, ContentContainer.transform);
            _textcomp = _currentgo.GetComponentInChildren<TextMeshProUGUI>();
            if (_currentitem.ElementType=="PARTSTUDIO")
                {
                    _textcomp.text = "Part Studio : ";
                }
            else if (_currentitem.ElementType == "ASSEMBLY")
                {
                    _textcomp.text = "Assembly : ";
                }
            _textcomp.text += _currentitem.Name ;//+ "\nLast modified by : " + _currentitem.ModifiedBy.Name + " on " + _currentitem.ModifiedAt + "\nOwned by : " + _currentitem.Owner.Name;
            _currentbutton = _currentgo.GetComponentInChildren<Button>();
            _imagethumbnail = _currentgo.GetComponentInChildren<Image>();
            _imagethumbnail.sprite = _currentitem.ThumbnailInfo.Image;
            _currentbutton.onClick.AddListener(() =>
            {
                Main.OpenTab(_currentitem);
            });
        }
    }

}
