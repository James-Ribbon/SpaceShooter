using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();

        if (bullet != null)
        {
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.SetActive(true);
        }
    }
}
