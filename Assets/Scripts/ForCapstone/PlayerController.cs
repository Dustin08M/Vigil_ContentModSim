using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement Controls")]
    [SerializeField] private int MoveSpeed;
    public bool isControllerEnabled;
    public bool isPlayerMoving;
    public CharacterController Controller;
    [Header("Mouse Look Controls")]
    public Camera PlayerCamera;
    [SerializeField, Range(0.5f, 100f)] private float mouseSens = 25f;
    private float m_rotateX;
    private float m_rotateY;

    bool isPlayingFootSteps;

    void Start()
    {
        isControllerEnabled = false;
        // This 5f is paired to sync with Days Count fade in time (See 'FadeCameraTerminal.cs')
        //And 'FadeDayCount.cs'
        Invoke("UnlockPlayerMovement", 5f);
    }
    void Update()
    {
        if (isControllerEnabled) MovePlayer();
    }

    public void MovePlayer()
    {
        //Move Player (Raw Version)
        if (!PauseMenu.isPaused)
        {
            isPlayerMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
            Vector3 m_player = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
            m_player *= MoveSpeed * Time.deltaTime;
            Controller.Move(m_player);
        }
        if (isPlayerMoving && !isPlayingFootSteps)
        {
            StartCoroutine(PlayFootStepSound());
        }

        //Look Around (Raw Version)
        /*
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mouseSens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSens;
        m_rotateY += mouseX;
        m_rotateX -= mouseY;
        m_rotateX = Mathf.Clamp(m_rotateX, -90f, 90f);
        //Rotate Cam along with the Player
        PlayerCamera.transform.rotation = Quaternion.Euler(m_rotateX, m_rotateY, 0); //Cam
        transform.rotation = Quaternion.Euler(0, m_rotateY, 0); // player
        */

    }
    public void UnlockPlayerMovement()
    {
        isControllerEnabled = true;
    }

    IEnumerator PlayFootStepSound()
    {
        isPlayingFootSteps = true;
        SoundManager.Instance.PlayFootStepSfx();
        yield return new WaitForSeconds(.6f);
        isPlayingFootSteps =false;
    }
}
