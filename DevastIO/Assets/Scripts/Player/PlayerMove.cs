using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void MovePlayer(Vector2 direction)
    {
        direction = direction.normalized;

        transform.position += new Vector3(direction.x, direction.y, 0) * _speed * Time.deltaTime;

        if (direction != Vector2.zero)
        {
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.back);
        }
    }
}
