using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class layout : MonoBehaviour
{
    
    public Image botaoComprar;
    public Image botaofoto;

    void Start()
    {
        botaoComprar.transform.position = new Vector2((botaoComprar.GetComponent<RectTransform>().sizeDelta.x) * 0.6f,
            Screen.height - botaoComprar.GetComponent<RectTransform>().sizeDelta.x * 0.6f);
        botaofoto.transform.position = new Vector2(Screen.width / 2, 
            botaofoto.GetComponent<RectTransform>().sizeDelta.x * 0.6f);
    }

    void Update()
    {
        print(Application.persistentDataPath); 
    }


}
