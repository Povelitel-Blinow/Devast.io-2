using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    [SerializeField] private float _speed;

    private GameObject _target;

    public void Init(GameObject target)
    {
        transform.parent = null;
        _target = target;
    }

    public void UpdateCamera()
    {
        Vector3 direction = (_target.transform.position - transform.position);

        direction = new Vector3(direction.x, direction.y, 0);

        transform.position += direction * Time.deltaTime * _speed;
    }
}
