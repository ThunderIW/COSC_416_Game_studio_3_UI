using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class CoinCounterUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI current;
    [SerializeField] private TextMeshProUGUI toUpdate;
    [SerializeField] private Transform coinTextContainer;
    [SerializeField] private float duration;
    [SerializeField] private Ease animationCurve;

    private float containerInitPosition;
    private float moveAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Canvas.ForceUpdateCanvases();
        current.SetText("0");
        toUpdate.SetText("0");
        containerInitPosition = coinTextContainer.localPosition.y;
        moveAmount = current.rectTransform.rect.height;

    }

    public void UpdateScore(int score)
    {
        toUpdate.SetText($"{score}");
        coinTextContainer.DOLocalMoveY(containerInitPosition + moveAmount, duration).SetEase(animationCurve);
        StartCoroutine(ResetCoinContainer(score));

    }

    private IEnumerator ResetCoinContainer(int score)
    {
        yield return new WaitForSeconds(duration);
        current.SetText($"{score}");
        Vector3 localPostion = coinTextContainer.localPosition;
        coinTextContainer.localPosition= new Vector3(localPostion.x,containerInitPosition,localPostion.z);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
