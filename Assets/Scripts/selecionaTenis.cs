using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selecionaTenis : MonoBehaviour {
	
	public GameObject[] sapatos; 
	public GameObject sapato;
	public GameObject target;
    public Canvas OnOff;


    public int i;
    private int indice = 0;

    public string[] URL;


    void Start () {


        i = 0; //indice do array, vai "chamar" o sapato

    }
	
	// Update is called once per frame
	void Update () {

        if (!sapato){ // Verifica se não existe sapato
            sapato = Instantiate(sapatos[i]); // Instancia o sapato selecionado
            sapato.transform.parent = target.transform; // Manda o sapato ser filho do target
            sapato.transform.localPosition = new Vector3(0.7f, -0.1f, -0.6f);
            sapato.transform.localRotation = Quaternion.Euler(0, 97.79f, 0);
            sapato.transform.localScale = new Vector3(7, 7, 7);

        }

    }
    public void urlLinkOrWeb()
    {
        Application.OpenURL(URL[i]);
    }

    void OnGUI(){

        GUI.color = new Color(0f, 0f, 0f, 0f); // Define cor como transparente

        if (GUI.Button(new Rect(Screen.width / 2, Screen.height * 0.08f, Screen.width / 2, Screen.height * 0.85f), "next")) { // Cria e define a area do botao pra avançar
            i++;
            if (i >= sapatos.Length)
            {

                i = 0;
            }

            Destroy(sapato);

        }

        if (GUI.Button(new Rect(0, Screen.height * 0.08f, Screen.width/2, Screen.height*0.85f), "back")) {// Cria e define a area do botao pra voltar
            i--;
            if (i < 0)
            {

                i = sapatos.Length - 1;
            }

            Destroy(sapato);

        }
        
    }
    public void CapturaDeTela()
    {
        ScreenCapture.CaptureScreenshot("Print" + indice.ToString() + ".png");
        indice++;
    }
}
