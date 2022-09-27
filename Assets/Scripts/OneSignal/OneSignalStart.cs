using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OneSignalSDK;

public class OneSignalStart : MonoBehaviour
{
    private void Start()
    {
        OneSignal.Default.Initialize("ea921d7e-5173-425a-87c2-4af0d499bd48");
    }
}
