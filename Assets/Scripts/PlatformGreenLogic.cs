using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGreenLogic : PlatformCommonLogic
{
    private void Awake()
    {
        value = 30;
    }

    private void Update()
    {
        ExistenceEvaluation();
    }
}
