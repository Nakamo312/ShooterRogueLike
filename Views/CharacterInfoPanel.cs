using System;
using System.Collections.Generic;
using UnityEngine;


public class CharacterInfoPanel : MonoBehaviour
{
    [SerializeField]
    private DataField _panelPrefab;

    public Dictionary<string, DataField> _panels;

    public void Init(EntityStats stats)
    {
        string json = JsonUtility.ToJson(stats);
        var data = JsonUtility.FromJson<Dictionary<string, object>>(json);
        foreach (KeyValuePair<string, object> kvp in data)
        {
            DataField newDataField =  Instantiate(_panelPrefab);
            _panels[kvp.Key] = newDataField;
        }
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}

