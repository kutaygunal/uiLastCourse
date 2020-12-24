using UnityEngine;
using System.Collections;
public class FadeInControl : MonoBehaviour
{
    private Animator hudAnim;
    void Awake()
    {
        hudAnim = GetComponent<Animator>();
    }
    public void HUDFade()
    {
        hudAnim.SetTrigger("FadeIn");
    }
}