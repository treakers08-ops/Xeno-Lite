using UnityEngine;
public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 15f;
    void Update() { transform.Translate(Vector3.forward * speed * Time.deltaTime); }
    void OnTriggerEnter(Collider other) { var h = other.GetComponent<Health>(); if(h!=null) { h.TakeDamage(damage); Destroy(gameObject); } }
}