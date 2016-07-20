using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PreLoader : MonoBehaviour {

	public Image _icones;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (IniciarTempo(3.0f));
	}

	public Vector3 Rotacionar(Vector3 _rotacao, float _speed){
		return _rotacao * Time.deltaTime * _speed;
	}

	public IEnumerator IniciarTempo(float _tempo){
		_icones.transform.Rotate (Rotacionar(-Vector3.forward,100.5f));
		yield return new WaitForSeconds(_tempo);
		Application.LoadLevel ("Scene_02");
	}
}
