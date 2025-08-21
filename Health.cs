using UnityEngine;
public class Health : MonoBehaviour
{
    public float hp = 100f;
    public void TakeDamage(float dmg) { hp -= dmg; if(hp<=0) Die(); }
    void Die() { Debug.Log(name + " died."); Destroy(gameObject); }
}