using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; // Khai báo biến [cite: 487]

    void Start()
    {
        // Lấy component SpriteRenderer trên chính object này
        spriteRenderer = GetComponent<SpriteRenderer>(); // [cite: 509]
    }

    void Update()
    {
        // Đảo ngược trạng thái: Đang hiện thì ẩn, đang ẩn thì hiện
        // Code này sẽ làm lửa nhấp nháy rất nhanh
        spriteRenderer.enabled = !spriteRenderer.enabled; // [cite: 532]
    }
}
