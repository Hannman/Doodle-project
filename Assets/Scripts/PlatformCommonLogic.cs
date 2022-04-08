using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCommonLogic : MonoBehaviour
{
    private bool counted = false;
    protected int value; //ценность платформы в очках 
    protected void ExistenceEvaluation()
    {
        var deltaX = Camera.main.transform.position.y - this.transform.position.y;
        if (deltaX > GameSettings.destructionHight)
        {
            Destroy(this.gameObject);
        }
    }

    public void ScoreIncrease() 
    {
        if (!counted)
        {
            counted = true;
            GameManager.AddPoints(value);
        }
    }
}
