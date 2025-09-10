using UnityEngine;


public class BlendShapeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public SkinnedMeshRenderer skmRenderer;

    void Bldshapechange(int bldindex,int bldvalue)
    {
        skmRenderer.SetBlendShapeWeight(bldindex,bldvalue);
    }
 
}
