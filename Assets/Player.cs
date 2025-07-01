using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    void Update()
    {
        float h = 0f;
        float v = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))  h = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) h = 1f;
        if (Input.GetKey(KeyCode.UpArrow))    v = 1f;
        if (Input.GetKey(KeyCode.DownArrow))  v = -1f;

        Vector3 moveDir = new Vector3(h, 0, v).normalized;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}