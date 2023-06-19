using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [Header("Default Values")]
    public float _animationSpeed = .5f;
    public CanvasGroup panelMainMenu, panelLoadGame, panelOption, panelConfirmationtab;

    private bool _isMainMenu, _isLoadMenu, _isOptionMenu;

    private void Start()
    {
        ShowPanelMainMenu();
    }
    public void ShowPanelMainMenu()
    {

        LeanTween.alphaCanvas(panelMainMenu, 1, _animationSpeed);
        panelMainMenu.blocksRaycasts = !panelMainMenu.blocksRaycasts;
        panelMainMenu.interactable = !panelMainMenu.interactable;

    }
    public void HidePanelMainMenu()
    {
        LeanTween.alphaCanvas(panelMainMenu, 0,_animationSpeed);
        panelMainMenu.blocksRaycasts = !panelMainMenu.blocksRaycasts;
        panelMainMenu.interactable = !panelMainMenu.interactable;

    }

    public void ShowPanelOptionPanel()
    {
        LeanTween.alphaCanvas(panelOption, 1, _animationSpeed);
        panelOption.blocksRaycasts = !panelOption.blocksRaycasts;
        panelOption.interactable = !panelOption.interactable;
    }
    public void HidePanelOptionPanel()
    {
        LeanTween.alphaCanvas(panelOption, 0, _animationSpeed);
        panelOption.blocksRaycasts = !panelOption.blocksRaycasts;
        panelOption.interactable = !panelOption.interactable;
    }
    public void ShowPanelLoadGame()
    {
        LeanTween.alphaCanvas(panelLoadGame, 1, _animationSpeed);
        panelLoadGame.blocksRaycasts = !panelLoadGame.blocksRaycasts;
        panelLoadGame.interactable = !panelLoadGame.interactable;

    }
    public void HidePanelLoadGame()
    {
        LeanTween.alphaCanvas(panelLoadGame, 0, _animationSpeed);
        panelLoadGame.blocksRaycasts = !panelLoadGame.blocksRaycasts;
        panelLoadGame.interactable = !panelLoadGame.interactable;
    }
    public void ShowConfirmationTab()
    {
        LeanTween.alphaCanvas(panelConfirmationtab, 1, _animationSpeed);
        panelConfirmationtab.blocksRaycasts = !panelConfirmationtab.blocksRaycasts;
        panelConfirmationtab.interactable = !panelConfirmationtab.interactable;
    }
    public void HideConfirmationTab()
    {
        LeanTween.alphaCanvas(panelConfirmationtab, 0, _animationSpeed);
        panelConfirmationtab.blocksRaycasts = !panelConfirmationtab.blocksRaycasts;
        panelConfirmationtab.interactable = !panelConfirmationtab.interactable;

    }
}
