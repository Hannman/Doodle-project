using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCommonLogic : MonoBehaviour
{
    protected void ExistenceEvaluation()
    {
        var deltaX = PlayerController.PlayerCurrentPositionY - this.transform.position.y;
        if (deltaX > GameSettings.destructionHight)
        {
            Destroy(this.gameObject);
        }
    }
}
