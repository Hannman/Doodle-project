using System.Collections;
using UnityEngine;

public class PlatformBrownLogic : PlatformCommonLogic
{
    public SpriteRenderer _poofSpriteRenderer;

    private void Awake()
    {
        value = 30;
    }

    private void Update()
    {
        ExistenceEvaluation();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            ScoreIncrease();
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            _poofSpriteRenderer.enabled = true;
            StartCoroutine(poofSequence(0.1f));
        }
       
    }

    private IEnumerator poofSequence(float sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        _poofSpriteRenderer.enabled = false;
        Destroy(gameObject);
    }
}
