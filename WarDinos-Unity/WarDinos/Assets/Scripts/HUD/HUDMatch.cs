using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDMatch : MonoBehaviour {
    public Button voltar;
    
	void Start () {
        voltar.onClick.AddListener(() => print("bite my shinny metal ass!"));
    }
}
