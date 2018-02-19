using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDMatch : MonoBehaviour {
    //Teste para ver a funcionalidade da função changeTooltipText
    private Text informationText;
    private string lastMessageString = " ";
    private int lastMessageFontSize = 16;
    private bool isMessaging = false;
    
    //Botão de voltar, funcionalidade já implementada.
    public Button voltar;
    
    //GameObjects do painel de unidades e upgrades. Implementar
    public GameObject panelUnits;
    public GameObject panelUpgrades;
    
    //Botões correspondentes às unidades. On click -> adicionar uma unidade no vetor
    public Button unitVelociraptor;
    public Button unitEstegossauro;
    public Button unitTriceratopo;
    public Button unitPterodactilo;
    public Button unitApatossauro;
    public Button unitTiranossauro;
    //Configuração para botões de unidades
    private UnitButton unitVelociraptorUB;
    private UnitButton unitEstegossauroUB;
    private UnitButton unitTriceratopoUB;
    private UnitButton unitPterodactiloUB;
    private UnitButton unitApatossauroUB;
    private UnitButton unitTiranossauroUB;

    //Botões correspondentes a seleção de lanes -> Implementar
    public Button buttonLane1;
    public Button buttonLane2;
    public Button buttonLane3;

	void Start () {
        voltar.onClick.AddListener(() => SceneManager.LoadScene("titlescreen"));
        CanvasGroup cgunits = panelUnits.GetComponent<CanvasGroup>();
        CanvasGroup cgupgrades = panelUpgrades.GetComponent<CanvasGroup>();
        buttonLane1.onClick.AddListener(ButtonLane1OnClick);
        buttonLane2.onClick.AddListener(ButtonLane2OnClick);
        buttonLane3.onClick.AddListener(ButtonLane3OnClick);

        unitVelociraptorUB = unitVelociraptor.GetComponent<UnitButton>();
        unitEstegossauroUB = unitEstegossauro.GetComponent<UnitButton>();
        unitTriceratopoUB = unitTriceratopo.GetComponent<UnitButton>();
        unitPterodactiloUB = unitPterodactilo.GetComponent<UnitButton>();
        unitApatossauroUB = unitApatossauro.GetComponent<UnitButton>();
        unitTiranossauroUB = unitTiranossauro.GetComponent<UnitButton>();
    }

    public void ButtonLane1OnClick()
    {
        
    }
    public void ButtonLane2OnClick()
    {
        
    }
    public void ButtonLane3OnClick()
    {
           
    }

/*Transformar isto em chamadas de evento!
private void updateDinoGroupInfo () {
        int dinoQuantity = 0;
        int displayGroupPrice = 0;
        for (int i=0; i<buttonUnitTiranossauroUB.getQuantityOnGroup(); i++) {
            dinoGroupFrames[dinoQuantity].sprite = buttonUnitTiranossauroUB.getSpriteInFrame();
            displayGroupPrice += pgoPlayerTRex.Custo;
            dinoQuantity++;
        }
        for (int i = 0; i < buttonUnitTriceratopoUB.getQuantityOnGroup(); i++) {
            dinoGroupFrames[dinoQuantity].sprite = buttonUnitTriceratopoUB.getSpriteInFrame();
            displayGroupPrice += pgoPlayerTricera.Custo;
            dinoQuantity++;
        }
        for (int i = 0; i < buttonUnitEstegossauroUB.getQuantityOnGroup(); i++) {
            dinoGroupFrames[dinoQuantity].sprite = buttonUnitEstegossauroUB.getSpriteInFrame();
            displayGroupPrice += pgoPlayerEstego.Custo;
            dinoQuantity++;
        }
        for (int i = 0; i < buttonUnitApatossauroUB.getQuantityOnGroup(); i++) {
            dinoGroupFrames[dinoQuantity].sprite = buttonUnitApatossauroUB.getSpriteInFrame();
            displayGroupPrice += pgoPlayerApato.Custo;
            dinoQuantity++;
        }
        for (int i = 0; i < buttonUnitVelociraptorUB.getQuantityOnGroup(); i++) {
            dinoGroupFrames[dinoQuantity].sprite = buttonUnitVelociraptorUB.getSpriteInFrame();
            displayGroupPrice += pgoPlayerVeloci.Custo;
            dinoQuantity++;
        }
        for (int i = 0; i < buttonUnitPterodactiloUB.getQuantityOnGroup(); i++) {
            dinoGroupFrames[dinoQuantity].sprite = buttonUnitPterodactiloUB.getSpriteInFrame();
            displayGroupPrice += pgoPlayerPtero.Custo;
            dinoQuantity++;
        }

        dinoGroupCostText.text = displayGroupPrice.ToString();

        // Preenche o que sobrou de espaço vazios no grupo com nenhuma imagem
        for (int i = dinoQuantity; i<4; i++) {
            dinoGroupFrames[i].sprite = dinoGroupFreeSlotSprite;
        }
    }
*/ 
}
