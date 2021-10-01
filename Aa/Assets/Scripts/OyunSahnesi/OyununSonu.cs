using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyununSonu : MonoBehaviour
{
    public GameObject DönenBüyükCember;
    public GameObject SpawnLokasyonu;

    public void OyunuBitir()
    {
        DönenBüyükCember.GetComponent<DonenBuyukCember>().enabled = false;
        SpawnLokasyonu.GetComponent<KucukCubukSpawner>().enabled = false;

    }
}
