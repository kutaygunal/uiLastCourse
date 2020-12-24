using UnityEngine;
using System.Collections;
public class FadeOutControl : MonoBehaviour
{
    private Animator menuAnim;
    void Awake()
    {
        menuAnim = GetComponent<Animator>();
    }
    public void MenuFade()
    {
        menuAnim.SetTrigger("FadeOut");
    }
}