using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LielumuMainisana : MonoBehaviour {
    public GameObject slaideris1;
    public GameObject slaideris2;
    public GameObject kurRadit;

    public void mainitielumuPlat()
    {
        float pasreizejaVertiba = slaideris1.GetComponent<Slider>().value;
        kurRadit.transform.localScale = new Vector3(1f*pasreizejaVertiba, slaideris2.GetComponent<Slider>().value, 0);
    }

    public void mainitielumuGar()
    {
        float pasreizejaVertiba = slaideris2.GetComponent<Slider>().value;
        kurRadit.transform.localScale = new Vector3(slaideris1.GetComponent<Slider>().value, 1f * pasreizejaVertiba, 0);
    }

}
