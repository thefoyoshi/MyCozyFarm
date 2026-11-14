using System;
using TMPro;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI build_info;
    void Start()
    {
        build_info.SetText(Application.version);
    }

    void FixedUpdate()
    {
        
    }
}
