using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    void Fire();
    void UpdateWeapon(float deltaTime);
    bool CanFire();
    float FireRate { get; }
    Transform[] FirePoints { get; }
    float[] FireAngles { get; }
}
