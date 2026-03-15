using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;
    private void Awake()
    {
        LivingEnemyCount++; // Quái sinh ra thì cộng 1
    }
    protected override void Die()
    {
        LivingEnemyCount--; // Quái chết thì trừ 1 đi

        // Gọi lại hàm Die() gốc của cha để nó sinh ra vụ nổ và tự xóa (Destroy)
        base.Die();
    }
 
}