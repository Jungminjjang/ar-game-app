using System.Collections;
using UnityEngine;

//서서히 사라지는 효과 인터페이스
interface IFadeable
{
    IEnumerator Fade(bool toggle, float howLong); //yield null -> Update()이후에 호출
    
}