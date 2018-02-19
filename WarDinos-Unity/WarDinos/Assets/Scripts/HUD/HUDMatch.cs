using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDMatch : MonoBehaviour {
    public Button voltar;
    
	void Start () {
        voltar.onClick.AddListener(() => SceneManager.LoadScene("titlescreen"));
    }
}
