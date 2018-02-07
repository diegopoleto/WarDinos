using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TitleScreenPressButton : MonoBehaviour {
    public GameObject gui;
    public GameObject music;
    public GameObject textObjectToModify;
    public string messageOfTheModification;

    private bool pressed = false;
    public Button PressToBegin;

    
    /*
    Na tela de ''Clique na tela para iniciar o jogo'' foi adicionado o controle por toque.
    */
    void Update () {
        //Verifica se ocorreu um toque na tela e então executa a função abaixo.
        if (!pressed && Input.touchCount>0) {
            pressed = true;
            
            //GUI DO MENU INICIAL
            gui.SetActive(true);
            //ATIVA A MUSICA DO JOGO
            music.SetActive(true);
            //RESTANTE DAS ROTINAS, NÃO PRECISAM COMPREENDER ISSO.
            textObjectToModify.GetComponent<Text>().text = messageOfTheModification;
            CanvasGroup cggui = gui.GetComponent<CanvasGroup>();
            StartCoroutine(routine: fadeInCanvas(cggui));
        }
    }

    void taskOnClickToMenu()
    {
        gui.SetActive(true);
        music.SetActive(true);

        textObjectToModify.GetComponent<Text>().text = messageOfTheModification;
        CanvasGroup cggui = gui.GetComponent<CanvasGroup>();
        StartCoroutine(routine: fadeInCanvas(cggui));
    }

    IEnumerator fadeInCanvas(CanvasGroup cg)
    {
        float time = 0.35f;
        while (cg.alpha < 1.0f)
        {
            cg.alpha += Time.deltaTime / time;
            yield return null;
        }
        cg.alpha = 1.0f;

        // Destroy the canvas components to enable the panel to have its buttons interactable
        Destroy(cg.GetComponentInParent<Canvas>());
        Destroy(cg);
    }
}
