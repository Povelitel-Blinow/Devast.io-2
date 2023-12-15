using UnityEngine;
using Unity.Netcode;

public class Server : NetworkBehaviour
{
    public static Server Instance { get; private set; }

    public override void OnNetworkSpawn()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }
}