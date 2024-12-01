using Assets.Scripts.warSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private WeaponStats stats;

    [SerializeField]
    private WeaponStatsData data;

    [SerializeField]
    private CameraController _cameraControoler;
    void Start()
    {
       stats = new WeaponStats(data);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = _cameraControoler.ThrowRay(_range).Value;

            float total_damage = damage * Mathf.Exp(-hit.distance/ drag_coef); 

            hit.collider?.gameObject.GetComponent<EnemyCollider>()?.TakeDamage(total_damage);
        }*/
    }
}
