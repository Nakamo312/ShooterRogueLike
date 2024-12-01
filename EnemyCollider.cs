using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void TakeDamage(float damage)
    {
        Debug.Log($"Shoot down with damage: {damage}");
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("shut down");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
