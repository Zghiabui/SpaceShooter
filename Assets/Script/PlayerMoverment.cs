using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // BƯỚC 1: Lấy vị trí chuột trên màn hình
         Debug.Log(Input.mousePosition); 

        // BƯỚC 2: Chuyển từ tọa độ màn hình sang tọa độ thế giới game
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // BƯỚC 3: Khóa trục Z lại bằng 0 (vì game 2D)
        worldPoint.z = 0;

        // BƯỚC 4: Gán vị trí tàu bằng vị trí vừa tính toán
        transform.position = worldPoint;
    }
}
