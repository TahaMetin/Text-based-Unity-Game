using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Durum")]

public class Durum : ScriptableObject {

    [TextArea(12, 10)] [SerializeField] string HikayeMetni;

    [SerializeField] Durum[] SonrakiDurumlar;

    public string DurumHikayesiAl()
    {
        return HikayeMetni;
    }

    public Durum[] SonrakiDurumlariAl()
    {
        return SonrakiDurumlar;
    }
}
