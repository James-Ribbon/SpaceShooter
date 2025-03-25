using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFactory : IProjectileFactory
{
    [SerializeField] private GameObject _projectilePrefab;

    public ProjectileFactory(GameObject projectilePrefab)
    {
        _projectilePrefab = projectilePrefab;
    }

    public GameObject CreateProjectile(Vector3 position, Quaternion rotation)
    {
        return Object.Instantiate(Resources.Load<GameObject>("Prefabs/Projectile"), position, rotation);
    }
}
