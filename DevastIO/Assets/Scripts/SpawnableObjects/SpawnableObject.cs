using Unity.Netcode;

public abstract class SpawnableObject : NetworkBehaviour
{
    public int SpawnID;

    public abstract void Init();
}
