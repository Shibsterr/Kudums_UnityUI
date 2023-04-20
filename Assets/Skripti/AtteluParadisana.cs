using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AtteluParadisana : MonoBehaviour {
    public Sprite[] koRadit;
    public GameObject kurRadit;
    public GameObject Zobens;
    public GameObject Wand;
    public GameObject Aizsargs;
    public GameObject ApgerbsBurvis;
    public GameObject ApgerbsKaravirs;


    public void izkritosaisFons(int indekss)
    {
        if (indekss == 0)
            kurRadit.GetComponent<Image>().sprite = koRadit[0];
        else if (indekss == 1)
            kurRadit.GetComponent<Image>().sprite = koRadit[1];
        else if (indekss == 2)
            kurRadit.GetComponent<Image>().sprite = koRadit[2];
        else if (indekss == 3)
            kurRadit.GetComponent<Image>().sprite = koRadit[3];
    }

    public void zobenaAttelosana(bool vertiba)
    {
        Zobens.SetActive(vertiba);
    }

    public void WandAttelosana(bool vertiba)
    {
        Wand.SetActive(vertiba);
    }

    public void AizsargaAttelosana(bool vertiba)
    {
        Aizsargs.SetActive(vertiba);
    }
    public void ApgerbsBAttelosana(bool vertiba)
    {
        ApgerbsBurvis.SetActive(vertiba);
    }
    public void ApgerbsKAttelosana(bool vertiba)
    {
        ApgerbsKaravirs.SetActive(vertiba);
    }

}
