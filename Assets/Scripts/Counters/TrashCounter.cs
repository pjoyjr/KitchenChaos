using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TrashCounter : BaseCounter {
    
    public static event EventHandler OnAnyObjectTrashed;

    new public static void ResetStaticData() {
        OnAnyObjectTrashed = null;
    }

    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            // Player is carrying something
            player.GetKitchenObject().DestroySelf();

            OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
        }
        else {
            // Player is not carrying anything
        }
    }
}
