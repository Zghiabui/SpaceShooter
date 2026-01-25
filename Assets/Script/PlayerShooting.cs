using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class PlayerShooting : MonoBehaviour
    {
        public GameObject bulletPrefab;     // Chứa bản mẫu viên đạn 
        public float shootingInterval = 0.2f; // Thời gian giãn cách giữa 2 phát bắn (0.2 giây) 
        private float lastBulletTime;       // Lưu thời điểm bắn viên đạn trước đó

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                if (Time.time - lastBulletTime > shootingInterval)
                {
                    ShootBullet();
                    lastBulletTime = Time.time; // Cập nhật lại thời gian bắn
                }
            }
        }

        void ShootBullet()
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}