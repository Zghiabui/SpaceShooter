using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; 
    public int defaultHealthPoint = 3; 
    protected int healthPoint;         

    private void Start()
    {
        healthPoint = defaultHealthPoint; 
    }

    // Hàm nhận sát thương
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return; 

        healthPoint -= damage; 

        if (healthPoint <= 0)
        {
            Die(); 
        }
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }
}