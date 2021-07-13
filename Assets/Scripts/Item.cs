using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour
{
    private bool check;     //처음 클릭을 확인하는 변수
    public GameObject back;

    private void Awake()
    {
        check= false;
    }

    public void ClikItem()
    {   //다이알로그 출력
        StartCoroutine(ActiveUI());
        Debug.Log(check);
        if(!check)
        {   //첫 클릭시 아이템 갯수 올림
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
