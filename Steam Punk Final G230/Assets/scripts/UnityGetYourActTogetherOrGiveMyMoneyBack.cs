// Patch to address strange issue with Prefabs
using UnityEngine.EventSystems;
using UnityEngine;
[ExecuteInEditMode]
public class UnityGetYourActTogetherOrGiveMyMoneyBack : MonoBehaviour
{
	public Vector3 m_anchoredPosition;
	void Start()
	{
		GetComponent<RectTransform>().anchoredPosition = m_anchoredPosition;
	}
#if UNITY_EDITOR
	void Update()
	{
		if (Application.isPlaying)
		{
			return;
		}
		m_anchoredPosition = GetComponent<RectTransform>().anchoredPosition3D;
	}
#endif
}
