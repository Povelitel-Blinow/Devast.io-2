using UnityEngine;

[CreateAssetMenu]
public class SpawnableObjectData : ScriptableObject
{
    public SpawnableObject SpawnObject = null;
    public int SpawnID => SpawnObject.SpawnID;
}
