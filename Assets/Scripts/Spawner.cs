using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] AttackerPrefabArray;

    void Update()
    {
        foreach (GameObject attacker in AttackerPrefabArray)
        {
            if (IsTimeToSpawn(attacker))
            {
                Spawn(attacker);
            }
        }
    }

    private bool IsTimeToSpawn(GameObject attacker)
    {
        Attacker newAttacker = attacker.GetComponent<Attacker>();
        float spawnDelay = newAttacker.SeenEverySeconds;
        float spawnsPerSecond = 1 / spawnDelay;

        if (Time.deltaTime > spawnDelay)
        {
            Debug.LogWarning("Spawn rate capped by frame rate");
        }

        float treshold = spawnsPerSecond * Time.deltaTime / 5;

        return (Random.value < treshold);
    }

    private void Spawn(GameObject attacker)
    {
        GameObject newAttacker = Instantiate(attacker) as GameObject;
        newAttacker.transform.parent = transform;
        newAttacker.transform.position = transform.position;
    }
}
