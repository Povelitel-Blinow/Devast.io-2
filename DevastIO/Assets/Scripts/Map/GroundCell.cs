using Unity.Netcode;
using UnityEngine;

public class GroundCell : NetworkBehaviour //it is not SpawnableObject because it is spawned only once
{
    [SerializeField] private Transform _center;

    private int _objectsLyingOnCount = 0;

    private Block _currentBlock;

    public bool isVacant => _objectsLyingOnCount == 0 && _currentBlock == null;
    
    public void Init(int x, int y)
    {
        transform.localPosition = new Vector3(x, y);
        NetworkObject.Spawn(true);
    }

    public void TryOccupy(Block block)
    {
        if (isVacant == false) return;

        //SpawnRequest request = new SpawnRequest(transform.position, transform.rotation, block.SpawnID); 

        _currentBlock = Instantiate(block, _center.transform.position, _center.transform.rotation);
        _currentBlock.NetworkObject.Spawn();
        _currentBlock.InitByServer();
    }

    public void LayDownObject()
    {
        _objectsLyingOnCount++;
    }

    public void PickUpObject()
    {
        _objectsLyingOnCount--;
    }
}
