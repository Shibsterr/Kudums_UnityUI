using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AtteluParadisana : MonoBehaviour {
    public Sprite[] koRadit;
    public GameObject kurRadit;

    //Rokas
    public GameObject Zobens;
    public GameObject Wand;
    public GameObject Aizsargs;

    //Uzvelks
    public GameObject ApgerbsBurvis;
    public GameObject ApgerbsKaravirs;
    
    //Cimdi
    public GameObject CimdiKLabaRoka;
    public GameObject CimdikKreisaRoka;

    public GameObject CimdiBLabaRoka;
    public GameObject CimdiBKreisaRoka;
  
    //Zabaki
    public GameObject ZabakiBKreisaKaja;
    public GameObject ZabakiBLabaKaja;

    public GameObject ZabakiKKreisaKaja;
    public GameObject ZabakikLabaKaja;


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

    public void CimdiKAttelosana(bool vertiba)
    {
        CimdiKLabaRoka.SetActive(vertiba);
        CimdikKreisaRoka.SetActive(vertiba);
    }

    public void CimdiBAttelosana(bool vertiba)
    {
        CimdiBLabaRoka.SetActive(vertiba);
        CimdiBKreisaRoka.SetActive(vertiba);
    }


    public void ZabakiBAttelosana(bool vertiba)
    {
        ZabakiBKreisaKaja.SetActive(vertiba);
        ZabakiBLabaKaja.SetActive(vertiba);
    }

    public void ZabakiKAttelosana(bool vertiba)
    {
        ZabakiKKreisaKaja.SetActive(vertiba);
        ZabakikLabaKaja.SetActive(vertiba);
    }


}
