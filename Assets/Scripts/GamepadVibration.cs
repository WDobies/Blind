using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure; // Required in C#

public class GamepadVibration : MonoBehaviour
{
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!prevState.IsConnected)
        {
            for (int i = 0; i < 4; ++i)
            {
                PlayerIndex testPlayerIndex = (PlayerIndex)i;
                GamePadState testState = GamePad.GetState(testPlayerIndex);
                if (testState.IsConnected)
                {
                    playerIndex = testPlayerIndex;
                }
            }
        }

        GamePad.SetVibration(playerIndex, 0.0f, 0.0f);
    }
}
