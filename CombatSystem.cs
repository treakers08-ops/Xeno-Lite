using UnityEngine;
public class CombatSystem : MonoBehaviour
{
    public float lightDamage = 10f;
    public float heavyDamage = 25f;
    public GameObject kiPrefab;
    public Transform kiSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) AttackLight();
        if (Input.GetKeyDown(KeyCode.K)) AttackHeavy();
        if (Input.GetKeyDown(KeyCode.L)) ShootKi();
    }

    void AttackLight() { Debug.Log("Light Attack: " + lightDamage); }
    void AttackHeavy() { Debug.Log("Heavy Attack: " + heavyDamage); }
    void ShootKi()
    {
        if (kiPrefab && kiSpawn) Instantiate(kiPrefab, kiSpawn.position, kiSpawn.rotation);
    }
}