using System.Collections;
using UnityEngine;

public class PlatformBrownLogic : PlatformCommonLogic
{
    public SpriteRenderer _poofSpriteRenderer;

    private void Update()
    {
        ExistenceEvaluation();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        _poofSpriteRenderer.enabled = true;
        StartCoroutine(poofSequence(0.1f));
    }

    private IEnumerator poofSequence(float sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        _poofSpriteRenderer.enabled = false;
        Destroy(gameObject);
    }
}
