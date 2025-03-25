using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProjectileFactory
{ 
    GameObject CreateProjectile(Vector3 position, Quaternion rotation);
}
