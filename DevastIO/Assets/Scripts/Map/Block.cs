using Unity.Netcode;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;

    [SerializeField] private NetworkObject _networkObject;
    
    public void Init(int x, int y)
    {
        transform.localPosition = new Vector3(x, y);
        _networkObject.Spawn(true);
    }
}
