using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IWeapon
{
    [SerializeField] protected WeaponSO _weaponData;
    
    //[SerializeField] protected float _fireRate = 0.5f;
    [SerializeField] protected Transform[] _firePoints;
    [SerializeField] protected float[] _fireAngles = { 0f };

    protected float _fireTimer;
    protected IProjectileFactory _projectileFactory;

    public float FireRate => _weaponData.fireRate;

    public Transform[] FirePoints => _firePoints;

    public float[] FireAngles => _fireAngles;

    protected virtual void Awake()
    {
        if (_firePoints == null || _firePoints.Length == 0)
        {
            _firePoints = new Transform[] { transform };
        }
    }

    public void Initialise(IProjectileFactory projectileFactory)
    {
        _projectileFactory = projectileFactory;
    }

    public bool CanFire()
    {
        return _fireTimer <= 0f;
    }

    public void Fire()
    {
        if (!CanFire())
        {
            return;
        }

        foreach (var firePoint in _firePoints)
        {
            foreach (var angle in _fireAngles)
            {
                FireProjectile(firePoint, angle);
            }
        }

        _fireTimer = 1f / FireRate;
    }


    protected virtual void FireProjectile(Transform firePoint, float angle)
    {
        Quaternion rotation = firePoint.rotation * Quaternion.Euler(0, 0, angle);
        _projectileFactory.CreateProjectile(firePoint.position, rotation);
    }

    public void UpdateWeapon(float deltaTime)
    {
        if (_fireTimer > 0f)
        {
            _fireTimer -= deltaTime;
        }
    }
}
