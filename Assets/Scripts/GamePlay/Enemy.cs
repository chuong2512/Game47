using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public SpriteRenderer image;

    public Sprite[] random;

    void OnEnable()
    {
        image.sprite = random[Random.Range(0, random.Length)];

        StartCoroutine(Hide());

        IEnumerator Hide()
        {
            yield return new WaitForSeconds(20);
            gameObject.SetActive(false);
        }
    }

    private void ShowLose()
    {
        if (GameManager.Instance.currentState != State.Lose)
        {
            GameManager.Instance.ShowLose();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("End"))
        {
            Debug.Log("Loseeeeee");
            ShowLose();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}