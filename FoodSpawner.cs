using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject foodPrefab; // Prefab olarak yemek
    public float spawnRate = 1f;  // Yükleme sıklığı
    public float minX = -5f, maxX = 5f; // X ekseninde rastgele yer

    void Start()
    {
        StartCoroutine(SpawnFood());
    }

    IEnumerator SpawnFood()
    {
        while (true)
        {
            // Rastgele bir gecikme süresiyle yiyecekler spaw edilecek
            float spawnDelay = Random.Range(0.5f, spawnRate);
            yield return new WaitForSeconds(spawnDelay);

            // X ekseninde rastgele bir pozisyon belirle
            float randomX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(randomX, 5f, 0f); // Y ekseninde yukarıdan başla

            // Prefab'i instantiate et
            GameObject food = Instantiate(foodPrefab, spawnPosition, Quaternion.identity);

            // Rigidbody2D'yi etkinleştir
            food.GetComponent<Rigidbody2D>().gravityScale = 1; // Yerçekimi etkisi
        }
    }
}
