using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float maxTime = 1f;
    private float timer = 0;


    void Start()
    {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10f);
            timer = 0;
        }
        timer += Time.deltaTime;

    }
}
