using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    private void Reset() => waypoints = GetComponentsInChildren<Waypoint>();

    // [MỚI] Vẽ đường kẻ nối các Waypoint với nhau (chỉ hiển thị lúc thiết kế)
    private void OnDrawGizmos()
    {
        if (waypoints == null) return;
        Gizmos.color = Color.green;
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
        }
    }

    // [MỚI] Indexer: Giúp lấy tọa độ của 1 điểm Waypoint cực nhanh (Ví dụ gọi: flyPath[0])
    public Vector3 this[int index] => waypoints[index].transform.position;
}