using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class PlayerSettingsOnStart : MonoBehaviour {

    public bool isRangeAttackingEnabled = false;
    public bool isMelleAttackingEnabled = false;

    private PlayerInput gKit2D_PlayerInput;
    private InventoryController gKit2D_InventoryController;

    private void Awake() {
        gKit2D_PlayerInput = GetComponent<PlayerInput>();
        gKit2D_InventoryController = GetComponent<InventoryController>();
    }

    private void Start() {
        InventorySetup();
        PlayerInputSetup();
    }

    private void PlayerInputSetup() {
        if (isRangeAttackingEnabled)
            gKit2D_PlayerInput.EnableRangedAttacking();
        else
            gKit2D_PlayerInput.DisableRangedAttacking();

        if (isMelleAttackingEnabled)
            gKit2D_PlayerInput.EnableMeleeAttacking();
        else
            gKit2D_PlayerInput.DisableMeleeAttacking();
    }

    private void InventorySetup() {
        gKit2D_InventoryController.Clear();
    }
}
