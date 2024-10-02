using Unity.VisualScripting;
using UnityEngine;

namespace Mybird
{
    public class CameraController : MonoBehaviour
    {
        #region Variavbles
        public Transform player;
        [SerializeField] private float offset = 1.5f;
        #endregion

        private void LateUpdate()
        {
            FollowPlayer();
        }

        //플레이어 따라가기
        void FollowPlayer()
        {
            transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
        }
    }
}

    

