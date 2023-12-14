using UnityEngine;

public class Bullet : SpawnableObject
{
    [Header("Settings")]
    [SerializeField] private float _speed;

    public override void InitByServer()
    {
        Destroy(gameObject, 5);
    }

    private void Update()
    {
        if(IsServer == false) return;

        transform.position += transform.up * _speed * Time.deltaTime;
    }
}
