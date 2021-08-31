using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletOriginTransform; // pour avoir la position nécessaire à la création des instances. Peut etre fait avec un gameObject.

    public float bulletSpeed = 10f;
    public GameObject playerReference;
    void Start()
    {
    }

    
    void Update()
    {

    }

    void OnShoot(InputValue value)
    {
        if(value.isPressed)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletOriginTransform.position, bulletOriginTransform.rotation);
        Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = bulletOriginTransform.forward * bulletSpeed;

        TeleportBullet tpBullet = newBullet.GetComponent<TeleportBullet>();
        tpBullet.player = playerReference; // player du TeleportBullet = Player du Gun


    }
}
