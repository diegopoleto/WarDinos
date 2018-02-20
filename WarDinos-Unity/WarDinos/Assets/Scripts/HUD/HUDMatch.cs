using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDMatch : MonoBehaviour {
    //GameObjects do Player
    public GameObject pgo;
    private Player pgoPlayer;
    private Dinossauro pgoPlayerApato;
    private Dinossauro pgoPlayerVeloci;
    private Dinossauro pgoPlayerTricera;
    private Dinossauro pgoPlayerTRex;
    private Dinossauro pgoPlayerEstego;
    private Dinossauro pgoPlayerPtero;
    private Dinossauro[] pgoPlayerDinoVector;
    
    
    //Teste para ver a funcionalidade da função changeTooltipText
    private Text informationText;
    private string lastMessageString = " ";
    private int lastMessageFontSize = 16;
    private bool isMessaging = false;
    
    private int quantity = 0;
    private int groupPrice = 0;
    public Image[] dinoGroupFrames;
    public Sprite dinoGroupFreeSlotSprite;
    public Text dinoGroupCostText;

        
    //Botão de voltar, funcionalidade já implementada.
    public Button voltar;
    
    //GameObjects do painel de unidades e upgrades. Implementar
    public GameObject panelUnits;
    public GameObject panelUpgrades;
    
    public Button addUnit;
    public Button subUnit;

    public Button unitVelociraptor;
    public Button unitEstegossauro;
    public Button unitTriceratopo;
    public Button unitPterodactilo;
    public Button unitApatossauro;
    public Button unitTiranossauro;
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
    private int selectedLane;

	void Start () {

        pgoPlayerDinoVector = new Dinossauro[7];
        pgoPlayer = pgo.GetComponent<Player>();
        pgoPlayerApato = pgoPlayerDinoVector[(int)GroupController.DinoType.APATOSSAURO] = pgoPlayer.goApatossauro.GetComponent<Dinossauro>();
        pgoPlayerPtero = pgoPlayerDinoVector[(int)GroupController.DinoType.PTERODACTILO] = pgoPlayer.goPterodactilo.GetComponent<Dinossauro>();
        pgoPlayerTRex = pgoPlayerDinoVector[(int)GroupController.DinoType.TREX] = pgoPlayer.goTrex.GetComponent<Dinossauro>();
        pgoPlayerEstego = pgoPlayerDinoVector[(int)GroupController.DinoType.ESTEGOSSAURO] = pgoPlayer.goEstegossauro.GetComponent<Dinossauro>();
        pgoPlayerTricera = pgoPlayerDinoVector[(int)GroupController.DinoType.TRICERATOPO] = pgoPlayer.goTriceratopo.GetComponent<Dinossauro>();
        pgoPlayerVeloci = pgoPlayerDinoVector[(int)GroupController.DinoType.RAPTOR] = pgoPlayer.goVelociraptor.GetComponent<Dinossauro>();

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
        selectedLane = 1;
    }
    public void ButtonLane2OnClick()
    {
        selectedLane = 2;
    }
    public void ButtonLane3OnClick()
    {
        selectedLane = 3;
    }
    
    /*
    Quando o botão AddUnit for tocado/clicado deve adicionar uma unidade do dinossauro correspondente
    */
    public void ButtonAddUnitOnClick(UnitButton dinoButton)
    {
        
        dinoGroupFrames[quantity].sprite = dinoButton.getSpriteInFrame();
        quantity++;
        if(dinoButton.DinosaurType == pgoPlayerTRex.DinoType)
            groupPrice += pgoPlayerTRex.Custo;
        if(dinoButton.DinosaurType == pgoPlayerTricera.DinoType)
            groupPrice += pgoPlayerTricera.Custo;
        if(dinoButton.DinosaurType == pgoPlayerEstego.DinoType)
            groupPrice += pgoPlayerEstego.Custo;
        if(dinoButton.DinosaurType == pgoPlayerApato.DinoType)
            groupPrice += pgoPlayerApato.Custo;
        if(dinoButton.DinosaurType == pgoPlayerVeloci.DinoType)
            groupPrice += pgoPlayerVeloci.Custo;
        if(dinoButton.DinosaurType == pgoPlayerPtero.DinoType)
            groupPrice += pgoPlayerPtero.Custo;
        if(dinoButton.DinosaurType == pgoPlayerTRex.DinoType)
            groupPrice += pgoPlayerTRex.Custo;

    dinoGroupCostText.text = groupPrice.ToString();
    }
    /*
    Quando o botão SubUnit for tocado/clicado deve retirar uma unidade de dinossauro
    */
    public void ButtonSubUnitOnClick()
    {
        quantity--;
        if(dinoButton.DinosaurType == pgoPlayerTRex.DinoType)
            groupPrice -= pgoPlayerTRex.Custo;
        if(dinoButton.DinosaurType == pgoPlayerTricera.DinoType)
            groupPrice -= pgoPlayerTricera.Custo;
        if(dinoButton.DinosaurType == pgoPlayerEstego.DinoType)
            groupPrice -= pgoPlayerEstego.Custo;
        if(dinoButton.DinosaurType == pgoPlayerApato.DinoType)
            groupPrice -= pgoPlayerApato.Custo;
        if(dinoButton.DinosaurType == pgoPlayerVeloci.DinoType)
            groupPrice -= pgoPlayerVeloci.Custo;
        if(dinoButton.DinosaurType == pgoPlayerPtero.DinoType)
            groupPrice -= pgoPlayerPtero.Custo;
        if(dinoButton.DinosaurType == pgoPlayerTRex.DinoType)
            groupPrice -= pgoPlayerTRex.Custo;

    dinoGroupCostText.text = groupPrice.ToString();
    }
}
