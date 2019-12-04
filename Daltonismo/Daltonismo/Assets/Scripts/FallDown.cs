using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * public class FallDown : MonoBehaviour, IPointerClickHandler
{
    public Transform transform;

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
 * */
public class FallDown : MonoBehaviour
{
    public Transform t;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        //uAdventure.Runner.Game.Instance.RunTarget("MainScene", 500, TransitionType.FadeIn);
        //uAdventure.Runner.Game.Instance.GameState.setFlag("asdasd", 1);
        //uAdventure.Runner.Game.Instance.GameState.setVar("asdasd", 1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t.Translate(new Vector3(0, -vel * Time.deltaTime, 0));
    }
}
