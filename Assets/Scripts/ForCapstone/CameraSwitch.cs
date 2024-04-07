using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject CameraTerminal;
    [SerializeField] private GameObject ModerateText;
    public GameObject BeginSessionText;

    public bool isInSession;
    public bool isPlayerModerating;
    public bool HasPlayerStartBootUp;
    MoveToTerminal Terminal;
    PlayerController _playerMovement;
    Camera _playerCamera;

    private void Start()
    {
        //Both false since player is on foot
        ModerateText.SetActive(false);
        BeginSessionText.SetActive(false);
        isInSession = false;
        Terminal = CameraTerminal.GetComponent<MoveToTerminal>();
        _playerMovement = Player.GetComponent<PlayerController>();
        _playerCamera = Player.GetComponentInChildren<Camera>();

    }

    private void Update()
    {
        if (isInSession && Input.GetKeyDown(KeyCode.Space) && !Terminal.isModerating)
        {
            EndSession();
        }
       /* if (isInSession && Input.GetKeyDown(KeyCode.Escape) && Terminal.isModerating)
        {
            Terminal.isModerating = false;
            Terminal.MoveCamTerminalBack();
            BeginSessionText.SetActive(true);
        }*/
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            ModerateText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && !isInSession && !HasPlayerStartBootUp)
            {
                StartSession();
            }
            if (HasPlayerStartBootUp)
            {
                ModerateText.SetActive(false);
                BeginSessionText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ModerateText.SetActive(false);
        }
    }
    //"Press 'F' to take a seat" doesnt disappear, has to change players pos again to do it
    private void StartSession()
    {
        isInSession = true;

        //This is my old method
        //Player.SetActive(false);
        _playerMovement.isControllerEnabled = false;
        _playerCamera.enabled = !_playerCamera.enabled;

        CameraTerminal.SetActive(true);
        ModerateText.SetActive(false);
        BeginSessionText.SetActive(true);
    }

    private void EndSession()
    {
        isInSession = false;
        //old method no need
        //Player.SetActive(true);
        _playerMovement.isControllerEnabled = true;
        _playerCamera.enabled = _playerCamera.enabled;

        CameraTerminal.SetActive(false);
        ModerateText.SetActive(false);
        BeginSessionText.SetActive(false);
    }
}
