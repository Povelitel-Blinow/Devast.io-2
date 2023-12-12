using UnityEngine;

public class Bullet : SpawnableObject
{
    [SerializeField] private float _speed;
    public override void Init()
    {
        Destroy(gameObject, 5);
    }

    public void Update()
    {
        if(IsOwner == false) return;

        transform.position += transform.up * _speed * Time.deltaTime;
    }

}
