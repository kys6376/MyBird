using TMPro;
using UnityEngine;

namespace MyBird
{
    public class GameManager : MonoBehaviour
    {
        #region Variables
        public static bool IsStart {  get; set; }

        public static bool IsDeath {  get; set; }

        public static int Score {  get; set; }

        public static int BestScore {  get; set; }

        //게임 UI
        public TextMeshProUGUI scoreText;
        #endregion

        private void Start()
        {
            //PlayerPrefs.DeleteAll();

            //초기화
            IsStart = false;
            IsDeath = false;
            Score = 0;
        }

        private void Update()
        {
            //score UI
            scoreText.text = Score.ToString();
        }
    }
}
