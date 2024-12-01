using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.warSystem
{
    [CreateAssetMenu(fileName = "New WeaponStats", menuName = "ScriptableObjects/WeaponStats", order = 1)]
    public class WeaponStatsData : ScriptableObject
    {
        public float baseDamage;
        public  double damage;
        public double chanceOfCrit;
        public double critModifier;
        public float firerate;
        public float range;
        public float reloadSpeed;
        public float magCapacity;
    }
}