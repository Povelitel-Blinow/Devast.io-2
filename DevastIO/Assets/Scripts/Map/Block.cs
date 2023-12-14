using UnityEngine;

public class Block : SpawnableObject
{
    public override void InitByServer()
    {
        Debug.Log("Spawned!");
    }
}
