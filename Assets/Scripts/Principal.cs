using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Principal : MonoBehaviour
{
    public Image background;
    public Image marca;
    public float logomarca;
    public float diferencay;
    public GameObject[] botoes;
    public GameObject botao;
    int posB = 0;
    public GameObject canvas;
    int cont;
    public Text SelDesejo;


    // Start is called before the first frame update
    void Start()
    {

        logomarca = (Screen.width * 0.7f);
        marca.rectTransform.sizeDelta = new Vector2(logomarca, logomarca / 2);
        marca.rectTransform.position = new Vector2(Screen.width / 2, Screen.height - marca.rectTransform.sizeDelta.y / 3);
        background.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        SelDesejo.rectTransform.position = new Vector2(Screen.width / 2, Screen.height - marca.rectTransform.sizeDelta.y *1.25f );
        SelDesejo.rectTransform.sizeDelta = new Vector2(logomarca, logomarca / 2);

        for (cont = 0; cont <= botoes.Length - 1; cont++)
        {
            botao = Instantiate(botoes[cont]);
            botao.transform.parent = canvas.transform;
            botao.transform.position = new Vector2(Screen.width / 2, Screen.height - logomarca / 2 - marca.rectTransform.sizeDelta.y - (80 * cont));
            botao.transform.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(Screen.width * 0.95f, 70);


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void masculinos()
    {
        SceneManager.LoadScene("cena1");
        //ScreenCapture.CaptureScreenshot("foto");
    }

    public void femininos()
    {
        SceneManager.LoadScene("cena2");
        //ScreenCapture.CaptureScreenshot("foto");
    }
}
