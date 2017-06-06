using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_scoring : MonoBehaviour {
    public static Score_check Sc;
    public Text poeni;

    void Start()
    {
        Sc = new Score_check();
    }
    
	void Update () {
        poeni.text = Sc.dajText();
	}
}
