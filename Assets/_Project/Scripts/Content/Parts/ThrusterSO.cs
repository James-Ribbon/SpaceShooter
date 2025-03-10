using UnityEngine;

[CreateAssetMenu(fileName = "ThrusterSO", menuName = "Ship Parts/Thrusters")]
public class ThrusterSO : PartSO
{
    public float thrustMultiplier;
    public float fuelConsumption;
    public Sprite thrusterSprite;
}