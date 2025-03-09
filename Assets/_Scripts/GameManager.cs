using TMPro;
using UnityEngine;

public class GameManager : SingletonMonoBehavior<GameManager>
{
    [SerializeField] private int score = 0;
    [SerializeField] private CoinCounterUI coincounter;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private GameObject settingsMenu;


    private bool isSettingsMenuActive;

    public bool IsSettingsMenuActive => isSettingsMenuActive;
    protected override void Awake()
    {
        base.Awake();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        inputManager.OnSettingMenu.AddListener(ToggleSettingsMenu);
        DisableSettingsMenu();


    }

    private void ToggleSettingsMenu() { 
        if(isSettingsMenuActive)
        {
            DisableSettingsMenu();
        }
        else
        {
            EnableSettingsMenu();

        }
    }

    private void EnableSettingsMenu() {
        Time.timeScale = 0f;
        settingsMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isSettingsMenuActive = true;
    }

    private void DisableSettingsMenu()
    {
        Time.timeScale = 1f;
        settingsMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isSettingsMenuActive = false;

    }


    public void IncreaseScore()
    {
        score++;
       
        coincounter.UpdateScore(score);
    }
}
