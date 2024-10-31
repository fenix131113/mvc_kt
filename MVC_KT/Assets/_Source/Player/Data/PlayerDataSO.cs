using UnityEngine;

namespace Player.Data
{
    [CreateAssetMenu(fileName = "New PlayerData", menuName = "SOs/New PlayerData")]
    public class PlayerDataSO : ScriptableObject
    {
        [field: SerializeField] public int PlayerMaxHealth { get; private set; }
        [field: SerializeField] public int PlayerMoveSpeed { get; private set; }
    }
}