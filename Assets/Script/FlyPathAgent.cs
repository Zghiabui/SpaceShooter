using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;    // Đường bay mà con quái này sẽ đi theo
    public float flySpeed = 2f; // Tốc độ bay
    private int nextIndex = 0; // Điểm đến tiếp theo (bắt đầu từ điểm số 0)

    void Update()
    {
        if (flyPath == null) return;

        // Nếu vị trí hiện tại CHƯA ĐẾN được điểm mục tiêu -> Tiếp tục bay tới đó
        if (transform.position != flyPath[nextIndex])
        {
            FlyToNextWaypoint();
        }
        else
        {
            // Nếu ĐÃ ĐẾN NƠI -> Chuyển mục tiêu sang điểm tiếp theo
            nextIndex++;
            // Nếu đã đi hết các điểm -> Hủy luôn con quái (hoặc cho nó quay lại tùy bạn)
            if (nextIndex >= flyPath.waypoints.Length)
            {
                Destroy(gameObject);
            }
        }
    }

    private void FlyToNextWaypoint()
    {
        // MoveTowards: Hàm tự động tính toán bước đi nhỏ mỗi khung hình để tiến về đích
        transform.position = Vector3.MoveTowards(
            transform.position,
            flyPath[nextIndex],
            flySpeed * Time.deltaTime
        );
    }
}