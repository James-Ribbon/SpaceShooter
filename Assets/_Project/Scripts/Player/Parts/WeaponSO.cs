using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "Ship Parts/Weapon")]
public class WeaponSO : PartSO
{
    public float damage;
    public float fireRate;
    public Sprite bulletSprite;
    public GameObject bulletPrefab;
}