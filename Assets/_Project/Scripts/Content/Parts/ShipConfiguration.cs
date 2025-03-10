using UnityEngine;

public class ShipConfiguration : MonoBehaviour
{
    public EngineSO engine;
    public WeaponSO weapon;
    public ThrusterSO thruster;
    public ShieldSO shield;

    public float GetTotalThrust()
    {
        return engine.baseThrust * thruster.thrustMultiplier;
    }

    public float GetFireRate()
    {
        return weapon.fireRate;
    }
}