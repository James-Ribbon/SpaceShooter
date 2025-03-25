using UnityEngine;
using System.Collections;

namespace Assets._Project.Scripts.Content
{
    [CreateAssetMenu(fileName = "ShipProfile", menuName = "Ship/ShipProfile")]
    public class ShipProfile : ScriptableObject
    {
        [System.Serializable]
        public struct DamageLevel
        {
            public int HealthThreshold;
            public Sprite Sprite;
        }

        public DamageLevel[] DamageLevels;
    }
} 