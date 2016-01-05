using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TabBar : MonoBehaviour {

    private List<GameObject> m_TabItems = null;

    void OnEnable()
    {
        if (m_TabItems != null)
        {
            m_TabItems.Clear();
        }
        else
        {
            m_TabItems = new List<GameObject>();
        }
        //m_TabItems = gameObject.
        foreach (Transform child in transform)
        {
            child.GetComponent<Button>().onClick.AddListener(TabBarClickItemCallBack);
            m_TabItems.Add(child.gameObject);
        }
    }

    private void TabBarClickItemCallBack()
    {
        Button current = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        Debug.Log("click " + current.name);
        SetSelectedItem(current.gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void SetSelectedItem(GameObject s)
    {
        for (int i = 0; i < m_TabItems.Count; i++)
        {
            m_TabItems[i].GetComponent<Image>().color = Color.white;
        }
        s.GetComponent<Image>().color = Color.green;
    }
}
