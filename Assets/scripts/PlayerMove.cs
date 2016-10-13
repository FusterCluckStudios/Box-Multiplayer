using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0,1, 1, 1, 1, 1);
        transform.Translate(0f, 0.5f, 0f);
    }

    void Update()
    {
        if (!isLocalPlayer)
            return;

        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertical") * 0.1f;

        transform.Translate(x, 0, z);
    }
}