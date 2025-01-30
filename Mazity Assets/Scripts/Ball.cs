using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameManagerSO Gm;
    [SerializeField] private int IdSubLevelZone;
    [SerializeField] private float BallDelay;
    [SerializeField] private float BallVelocity;
    [SerializeField] private Vector3 RollingDirection = Vector3.forward;
    private AudioSource BallSound;
    private bool BallActivated = false;
    private float timer = 0f;
    private bool SounPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        Gm.Sublevel += Activar;
        BallSound = GetComponent<AudioSource>();
    }

    private void Activar(int BolaActivada)
    {
      if(BolaActivada == IdSubLevelZone)
        {
            BallActivated = true;
            BallSound.Play();
        }
    }

  

    // Update is called once per frame
    void Update()
    {
        if (BallActivated)
        {
            timer += Time.deltaTime;

            if (timer >= BallDelay)
            {
                if (BallSound != null && !BallSound.isPlaying && !SounPlayed)
                {
                    BallSound.Play();
                    SounPlayed=true;
                }

                transform.Translate(RollingDirection.normalized * BallVelocity * Time.deltaTime , Space.World);
                float rotationAmount = BallVelocity * Time.deltaTime * 360f / (2f * Mathf.PI * transform.localScale.x);
                transform.Rotate(Vector3.left * rotationAmount);
                
            }
        }
    }
}
