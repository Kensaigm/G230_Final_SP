using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif


[ExecuteInEditMode]
public class TMPBugSolver : MonoBehaviour
{
#if UNITY_EDITOR
	void OnEnable()
	{
		PrefabUtility.prefabInstanceUpdated += eventon_prefab_instance_updated;
	}
	void OnDisable()
	{
		PrefabUtility.prefabInstanceUpdated -= eventon_prefab_instance_updated;
	}

	private GameObject m_new_instance;
	private GameObject m_old_instance;
	private string m_childpath;

	private void eventon_prefab_instance_updated(GameObject instance)
	{
		if (PrefabUtility.GetPrefabType(instance) != PrefabType.PrefabInstance)
			return;
		if (instance != gameObject)
			return;
		Debug.Log(instance + " click apply");
		var pref = PrefabUtility.GetPrefabParent(instance);
		//var path = AssetDatabase.GetAssetPath(pref);
		//Debug.Log(path);
		m_old_instance = instance;
		m_new_instance = PrefabUtility.InstantiatePrefab(pref) as GameObject;
		Invoke("delaydestroy", 0.1f);

		m_childpath = findchildpath(instance.transform, Selection.activeTransform);
		Debug.Log(m_childpath);
	}
	private void delaydestroy()
	{
		GameObject.DestroyImmediate(m_old_instance);
		if (m_childpath == null)
		{
			Selection.activeGameObject = m_new_instance;
		}
		else
		{
			Selection.activeTransform = m_new_instance.transform.Find(m_childpath);
			EditorGUIUtility.PingObject(Selection.activeTransform);
		}

		m_old_instance = null;
		m_new_instance = null;
		m_childpath = null;
	}

	private string findchildpath(Transform parent, Transform child)
	{
		if (parent == child)
			return null;

		string path = child.name;
		child = child.parent;
		while (child != parent && child != child.root)
		{
			path = child.name + "/" + path;
			child = child.parent;
		}
		return path;
	}

#endif
}
