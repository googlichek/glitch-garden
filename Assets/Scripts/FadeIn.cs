using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float FadeInTIme;

    private Image _fadePanel;
    private Color _currentColor = Color.black;

	void Start ()
	{
	    _fadePanel = GetComponent<Image>();
	}
	
	void Update ()
    {
	    if (Time.timeSinceLevelLoad < FadeInTIme)
	    {
	        var alphaChange = Time.deltaTime / FadeInTIme;
	        _currentColor.a -= alphaChange;
	        _fadePanel.color = _currentColor;
	    }
	    else
	    {
	        gameObject.SetActive(false);
	    }
	}
}
