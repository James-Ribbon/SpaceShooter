using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float timer = 0f;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            gameObject.SetActive(false);
            timer = 0f;
        }

        transform.Translate(Vector3.up * Time.deltaTime * 10f);
    }

}
