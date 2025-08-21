using UnityEngine;
public class PlayerVRController : MonoBehaviour
{
    public float speed = 3f;
    public float flightSpeed = 5f;
    private bool flying = false;
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (flying) move.y = Input.GetAxis("Jump");
        transform.Translate(move * (flying ? flightSpeed : speed) * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.F)) flying = !flying;
    }
}