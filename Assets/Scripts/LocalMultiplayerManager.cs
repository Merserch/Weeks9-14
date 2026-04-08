using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LocalMultiplayerManager : MonoBehaviour
{
    // This script manages player joining and assigns sprites to new players.
    public List<Sprite> playerSprites;
    public List<PlayerInput> players;   

    public void OnPlayerJoin(PlayerInput player)
    {
        // Add the new player to the list
        players.Add(player);
        // Assign a sprite to the new player based on their index
        SpriteRenderer sr = player.GetComponent<SpriteRenderer>();
        sr.sprite = playerSprites[player.playerIndex];
        // Set up the player's controller reference
        LocalMultiplayerController controller = player.GetComponent<LocalMultiplayerController>();
        controller.manager = this;
    }

    public void PlayerAttacking(PlayerInput attackingPlayer)
    {
        for(int i = 0; i < players.Count; i++)
        {
            if(attackingPlayer == players[i]) continue; // Skip the attacking player

            if (Vector2.Distance(attackingPlayer.transform.position, players[i].transform.position) < 0.5f)
            {
                Debug.Log("Player " + attackingPlayer.playerIndex + " hit player " + players[i].playerIndex + "!");

            }
        }
    }
}
