using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 5f; 

    void Update()
    {
        // Lấy vị trí hiện tại
        var newPosition = transform.position;
        // Cộng thêm vào trục Y (bay lên)
        newPosition.y += Time.deltaTime * flySpeed;
        // Gán lại vị trí mới
        transform.position = newPosition;

    }
}
