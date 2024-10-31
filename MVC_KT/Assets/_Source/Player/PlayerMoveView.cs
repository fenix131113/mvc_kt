using UnityEngine;

namespace Player
{
    public class PlayerMoveView : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        
        public void Move(Vector2 moveVector)
        {
            rb.MovePosition((Vector2)rb.transform.position + moveVector);
        }
    }
}