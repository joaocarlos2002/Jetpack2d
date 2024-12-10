using UnityEngine;

public class pipe : MonoBehaviour
{
    public float speed = 1f;


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
