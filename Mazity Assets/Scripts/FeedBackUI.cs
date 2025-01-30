using UnityEngine;
using TMPro;

public class FeedBackUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeGainedText;
    [SerializeField] private TextMeshProUGUI timeLostText;
    private float DisplayTime = 1.5f; // duracion en pantalla
    private float TimeGainedTimer = 0f;
    private float TimeLostTimer = 0f;

    private void Update()
    {
        if (timeGainedText.gameObject.activeSelf)
        {
            TimeGainedTimer -= Time.deltaTime;
            if (TimeGainedTimer <= 0)
            {
                timeGainedText.gameObject.SetActive(false);
            }
        }

        if (timeLostText.gameObject.activeSelf)
        {
            TimeLostTimer -= Time.deltaTime;
            if (TimeLostTimer <= 0)
            {
                timeLostText.gameObject.SetActive(false);
            }
        }
    }

    public void ShowTimeGained()
    {
        timeGainedText.gameObject.SetActive(true);
        TimeGainedTimer = DisplayTime;
    }

    public void ShowTimeLost()
    {
        timeLostText.gameObject.SetActive(true);
        TimeLostTimer = DisplayTime;
    }
}