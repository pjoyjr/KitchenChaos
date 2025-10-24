using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayingClockUI : MonoBehaviour {

    [SerializeField] private UnityEngine.UI.Image timerImage;

    private void Update() {
        if (KitchenGameManager.Instance.IsGamePlaying()) {
            timerImage.fillAmount = KitchenGameManager.Instance.GetGamePlayingTimerNormalized();
        } else {
        }
    }
}
