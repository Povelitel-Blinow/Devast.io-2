using Unity.Netcode;
using UnityEngine;

public class Block : NetworkBehaviour
{
    [SerializeField] private Sprite _sprite;
    
    public void Init(int x, int y)
    {
        transform.localPosition = new Vector3(x, y);
        NetworkObject.Spawn(true);
    }
}
