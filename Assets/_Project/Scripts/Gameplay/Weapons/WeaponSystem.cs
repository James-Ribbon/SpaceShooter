using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    [SerializeField]
    private Weapon[] _weapons;
    [SerializeField]
    private GameObject _projectilePrefab;

    private IProjectileFactory _projectileFactory;

    private void Awake()
    {
        _projectileFactory = new ProjectileFactory(_projectilePrefab);

        foreach (var weapon in _weapons)
        {
            weapon.Initialise(_projectileFactory);
        }

        //_weapon.Initialise(new ProjectileFactory(_weapon));
    }

    private void Update()
    {
        float deltaTime = Time.deltaTime;

        foreach (var weapon in _weapons)
        {
            weapon.UpdateWeapon(deltaTime);

            if (weapon.CanFire())
            {
                weapon.Fire();
            }
        }
    }
}
