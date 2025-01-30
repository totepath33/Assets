using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCentral : MonoBehaviour
{
    [SerializeField] float TimeRemaining = 180; // tiempo inicial en segundos (3 minutos)
    [SerializeField] Text TimerText; // referencia al componente Text de la UI
    private bool timerIsRunning = false;

    void Update()
    {
        if (timerIsRunning)
        {
            if (TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime; // reducir tiempo
                UpdateTimerUI();
            }
            else
            {
                TimeRemaining = 0; // evitar que el tiempo sea negativo
                timerIsRunning = false;
                GameOver();
               
            }
        }
    }

    public void StartTimer()
    {
        timerIsRunning = true;
    }

    public void StopTimer()
    {
        timerIsRunning = false;
    }

    public void AddTime(float extraTime)
    {
        TimeRemaining += extraTime;
       
        UpdateTimerUI();
    }

    public void RestTime (float Mtime)
    {
        TimeRemaining -= Mtime;

        UpdateTimerUI();
    }
    private void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;  // cursor visible
        SceneManager.LoadScene(3);    
    }
    private void UpdateTimerUI()
    {
      
        int minutes = Mathf.FloorToInt(TimeRemaining / 60);
        int seconds = Mathf.FloorToInt(TimeRemaining % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}