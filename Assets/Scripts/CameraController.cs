using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    protected Transform playerCameraTF;

    protected float pos_x = 0.0f, pos_y = 0.0f, pos_z = 0.0f, default_speed = 0.5f;

    void Start()
    {
        playerCameraTF = player.GetComponent<Transform>();

        pos_x = playerCameraTF.transform.position.x;
        pos_y = playerCameraTF.transform.position.y;
        pos_z = playerCameraTF.transform.position.z;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) { player.transform.SetPositionAndRotation(new Vector3(pos_x, pos_y, pos_z += default_speed), Quaternion.Euler(0.0f, 0.0f, 0.0f)); }
        if (Input.GetKey(KeyCode.S)) { player.transform.SetPositionAndRotation(new Vector3(pos_x, pos_y, pos_z -= default_speed), Quaternion.Euler(0.0f, 0.0f, 0.0f)); }
        if (Input.GetKey(KeyCode.A)) { player.transform.SetPositionAndRotation(new Vector3(pos_x -= default_speed, pos_y, pos_z), Quaternion.Euler(0.0f, 0.0f, 0.0f)); }
        if (Input.GetKey(KeyCode.D)) { player.transform.SetPositionAndRotation(new Vector3(pos_x += default_speed, pos_y, pos_z), Quaternion.Euler(0.0f, 0.0f, 0.0f)); }
    }

    // void Update() {}
}
