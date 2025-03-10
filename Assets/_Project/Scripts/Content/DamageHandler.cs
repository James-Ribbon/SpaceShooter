using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.Content
{
    public class DamageHandler : MonoBehaviour
    {
        public ShipProfile shipProfile;

        [SerializeField]
        private SpriteRenderer spriteRenderer;

        public int damageState = 0;

        void Start()
        {
            damageState = 0;
            Debug.Log(shipProfile.DamageLevels.Length);
            //UpdateSprite();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                damageState++;
                UpdateSprite();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                damageState--;
                UpdateSprite();
            }
        }

        void UpdateSprite()
        {
            foreach (var level in shipProfile.DamageLevels)
            {
                if (damageState <= level.HealthThreshold)
                {
                    spriteRenderer.sprite = level.Sprite;
                    break;
                }
            }
        }
    }
}