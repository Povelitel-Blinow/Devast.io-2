using UnityEngine;
using Unity.Netcode;

public class Server : NetworkBehaviour
{
    [SerializeField] private SpawnableObjectsList _spawnables;
    public static Server Instance { get; private set; }

    public override void OnNetworkSpawn()
    {
        //if (IsOwner == false) return;

        if (Instance == null)
        {
            Instance = this;
            Debug.Log("Singletone is working");
            return;
        }
        Destroy(gameObject);
    }

    [ServerRpc(RequireOwnership = false)]
    public void SpawnObjectServerRpc(SpawnRequest spawnRequest)
    {
        Debug.Log(111);
        SpawnableObject spawnableObject = GetObjectByID(spawnRequest.SpawnID); 

        SpawnableObject newObject = Instantiate(spawnableObject, spawnRequest.SpawnPos, spawnRequest.SpawnRot);

        newObject.NetworkObject.Spawn();
        newObject.Init();
    }

    private SpawnableObject GetObjectByID(int id)
    {
        foreach(SpawnableObjectData s in _spawnables.SpawnableObjects)
        {
            if(s.SpawnID == id)
                return s.SpawnObject;
        }
        throw new System.Exception($"No spawnable object with id = {id} in list");
    }
}

public struct SpawnRequest : INetworkSerializable
{
    public int SpawnID;

    public Vector3 SpawnPos;
    public Quaternion SpawnRot;

    //I'll search how to set parent
    //public Transform _parent;

    public SpawnRequest(Vector3 spawnPos, Quaternion spawnRot, int spawnID)
    {
        SpawnPos = spawnPos;
        SpawnRot = spawnRot;
        SpawnID = spawnID;
    }

    public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
    {
        serializer.SerializeValue(ref SpawnPos);
        serializer.SerializeValue(ref SpawnRot);
        serializer.SerializeValue(ref SpawnID);
    }
}
