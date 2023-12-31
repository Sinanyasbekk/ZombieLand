﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Manager/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField]
    private string _gameversion = "0.0.0";
    public string GameVersion { get { return _gameversion; } }

    [SerializeField]
    private string _nickname = "Persetons";
    
    public string NickName
    {
        get
        {
            int value = Random.Range(0, 9999);
            return _nickname + value.ToString();
        }
    }
}
