﻿using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UIController : MonoBehaviour
{
    public GameController gameController;

    public Player player1;

    public Player player2;

    public Wind wind;

    public Text turnText;

    public Slider player1HealthSlider;

    public Slider player2HealthSlider;

    public Slider player1ChargeSlider;

    public Slider player2ChargeSlider;

    public Slider windLeftSlider;

    public Slider windRightSlider;

    void Update()
    {
        switch (gameController.state)
        {
            case GameController.GameState.P1Turn:
                turnText.text = "Player 1's turn";
                break;
            case GameController.GameState.P2Turn:
                turnText.text = "Player 2's turn";
                break;
            case GameController.GameState.P1Win:
                turnText.text = "Player 1 has won the game!";
                break;
            case GameController.GameState.P2Win:
                turnText.text = "Player 2 has won the game!";
                break;
            default:
                turnText.text = "";
                break;
        }

        player1HealthSlider.value = player1.health;
        player2HealthSlider.value = player2.health;

        player1ChargeSlider.value = player1.strength;
        player2ChargeSlider.value = player2.strength;

        // TODO Mungkin mau ganti wind slidernya dengan yang "lebih manusiawi?"
        windLeftSlider.value = wind.strength;
        windRightSlider.value = wind.strength;
    }
}
