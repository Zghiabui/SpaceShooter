using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // [System.Serializable] giúp biến class này hiển thị được trong bảng Inspector của Unity
    [System.Serializable]
    public class Wave
    {
        public GameObject enemyPrefab; // Loại quái vật
        public int count;              // Số lượng quái trong đợt này
        public float spawnInterval;    // Khoảng cách thời gian sinh 2 con
        public FlyPath path;           // Đường bay cho đợt quái này
    }

    public Wave[] waves; // Danh sách các đợt quái
    public float timeBetweenWaves = 3f; // Thời gian nghỉ giữa 2 đợt

    void Start()
    {
        // Bắt đầu đẻ quái bằng Coroutine
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        // Duyệt qua từng đợt (Wave) trong danh sách
        foreach (Wave wave in waves)
        {
            // Sinh từng con quái trong 1 đợt
            for (int i = 0; i < wave.count; i++)
            {
                // Sinh ra quái vật
                GameObject enemy = Instantiate(wave.enemyPrefab, transform.position, Quaternion.identity);

                // Gán đường bay cho con quái vừa sinh ra
                FlyPathAgent agent = enemy.GetComponent<FlyPathAgent>();
                if (agent != null) agent.flyPath = wave.path;

                // Tạm dừng 1 khoảng thời gian rồi mới đẻ con tiếp theo
                yield return new WaitForSeconds(wave.spawnInterval);
            }

            // Đẻ xong 1 đợt -> Nghỉ ngơi trước khi đẻ đợt tiếp theo
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
}