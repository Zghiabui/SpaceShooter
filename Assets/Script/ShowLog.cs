using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Start chạy 1 lần khi bắt đầu game
    void Start()
    {
        Debug.Log("Hello World!"); // [cite: 458]
    }

    // Update chạy liên tục mỗi khung hình (khoảng 60 lần/giây)
    void Update()
    {
        // In ra số frame hiện tại
        Debug.Log("Update called! " + Time.frameCount); // [cite: 473]
    }
}
