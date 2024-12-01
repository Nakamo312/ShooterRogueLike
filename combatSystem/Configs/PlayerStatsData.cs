using UnityEditor;
using UnityEngine;


    [CreateAssetMenu(fileName = "New Stats", menuName = "ScriptableObjects/PlayerStats", order = 1)]
    public class PlayerStatsData : EntityStatsData
    {
        public float jumpForce;
        public float jerkForce;
    }
