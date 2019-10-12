using IO.Swagger.Model;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;

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
   


    void Start()
    {
        var _json = Resources.Load<TextAsset>("documents");
        RefreshDocumentList (JsonConvert.DeserializeObject<DocumentsGetDocumentsResponse200>(_json.text));
    }
    public void  RefreshDocumentList(DocumentsGetDocumentsResponse200 List)
    {
        gameObject.SetActive(true);
        foreach (DocumentsGetDocumentsResponse200Items _currentitem  in List.Items)
        {
            _currentgo= Instantiate(DocumentPrefab,ContentContainer.transform);
            _textcomp = _currentgo.GetComponentInChildren<TextMeshProUGUI>();
            _textcomp.text = "Document Name : " + _currentitem.Name + "\nLast modified by : " + _currentitem.ModifiedBy.Name + " on " + _currentitem.ModifiedAt + "\nOwned by : " + _currentitem.Owner.Name;
            _currentbutton = _currentgo.GetComponentInChildren<Button>();
            _imagethumbnail = _currentgo.GetComponentInChildren<Image>();
            _imagethumbnail.sprite = Imagetoshow;
            _currentbutton.onClick.AddListener(() =>
            {
                Debug.Log(_currentitem.Id);
            });
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
