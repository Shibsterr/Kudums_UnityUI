using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarduParadisana : MonoBehaviour {
  
    private string teksts;
    private string teksts2;
    public GameObject ievadesLauksVards;
    public GameObject ievadesLauksCipars;
    public GameObject TekstaLauks1;

    public void NolasitTekstu()
    {
        teksts = ievadesLauksVards.GetComponent<Text>().text;
        teksts2 = ievadesLauksCipars.GetComponent<Text>().text;
        TekstaLauks1.GetComponent<Text>().text = "Tavu telu sauc "+ teksts + " un vinam ir "+ teksts2 + " gadi.";
    }
}
