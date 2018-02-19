using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDMatch : MonoBehaviour {
    public Button voltar;
    public GameObject panelUnits;
    public GameObject panelUpgrades;

	void Start () {
        voltar.onClick.AddListener(() => SceneManager.LoadScene("titlescreen"));
        CanvasGroup cgunits = panelUnits.GetComponent<CanvasGroup>();
        CanvasGroup cgupgrades = panelUpgrades.GetComponent<CanvasGroup>();
    }


}
