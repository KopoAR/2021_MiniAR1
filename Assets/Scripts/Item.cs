using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour
{
    private bool check;     //ó�� Ŭ���� Ȯ���ϴ� ����
    public GameObject back;

    private void Awake()
    {
        check= false;
    }

    public void ClikItem()
    {   //���̾˷α� ���
        StartCoroutine(ActiveUI());
        Debug.Log(check);
        if(!check)
        {   //ù Ŭ���� ������ ���� �ø�
            check = true;
            ItemManager.instance.ItemCountAdd();
        }
    }

    private IEnumerator ActiveUI()
    {
        back.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        back.SetActive(false);
    }
}
