using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunYöneticisiscripit : MonoBehaviour {

    [SerializeField] Text OyunHikayesiYazısı;
    [SerializeField] Durum BaşlangiçDurumu;
    Durum GüncelDurum;
	
	void Start () {
        GüncelDurum = BaşlangiçDurumu;
        OyunHikayesiYazısı.text = GüncelDurum.DurumHikayesiAl();
	}
	
	
	void Update () {

        var SonrakiDurumlar = GüncelDurum.SonrakiDurumlariAl();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GüncelDurum = SonrakiDurumlar[0];           
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GüncelDurum = SonrakiDurumlar[1];
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GüncelDurum = SonrakiDurumlar[2];
        }


        OyunHikayesiYazısı.text = GüncelDurum.DurumHikayesiAl();
	}


}
