using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform playerPos;
    [SerializeField] private Transform CameraPos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newProjectile = Instantiate(projectile, transform.position,
                new quaternion(CameraPos.rotation.x, playerPos.rotation.y, CameraPos.rotation.z, playerPos.rotation.w));
        }
    }
}
