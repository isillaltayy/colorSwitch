using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speedToRotate = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speedToRotate * Time.deltaTime);
    }
}
