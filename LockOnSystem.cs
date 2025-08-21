using UnityEngine;
public class LockOnSystem : MonoBehaviour
{
    public Transform target;
    void Update() { if(target) transform.LookAt(target); }
}