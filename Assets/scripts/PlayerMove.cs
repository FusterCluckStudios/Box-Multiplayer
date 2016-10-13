using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertical") * 0.1f;

        transform.Translate(x, 0, z);
    }
}