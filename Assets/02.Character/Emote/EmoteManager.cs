using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteManager : MonoBehaviour
{
    [SerializeField]
    private GameObject head;

    private SkinnedMeshRenderer skinnedMeshRenderer;
    private int intBlendCount;

    // Start is called before the first frame update
    void Start()
    {
    
        skinnedMeshRenderer = head.GetComponent<SkinnedMeshRenderer>();
        intBlendCount = skinnedMeshRenderer.sharedMesh.blendShapeCount;
        RisetHyojyo();

        skinnedMeshRenderer.SetBlendShapeWeight(28, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSmile(int num)
    {
        //random
        if(num==11)
        {
            num = Random.Range(0,11);
        }

        switch (num)
        {
            case 0:
                //normal
                RisetHyojyo();
                break;
            case 1:
                //smile
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(9, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(15, 100);
                break;
            case 2:
                //close
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(16, 100);
                break;
            case 3:
                //angry
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(3, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(12, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(17, 100);
                break;
            case 4:
                //jitome
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(0, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(8, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(18, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(26, 100);
             
                break;
            case 5:
                //nagomi
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(2, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(27, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(9, 100);
                break;
            case 6:
                //surprise
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(7, 45.3f);
                skinnedMeshRenderer.SetBlendShapeWeight(24, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(25, 90);
                break;
            case 7:
                //kirame
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(23, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(26, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(4, 100);
                break;
            case 8:
                //w
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(2, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(13, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(18, 100);
                break;
            case 9:
                //fun
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(28, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(10, 100);
                break;
            case 10:
                //wink
                RisetHyojyo();
                skinnedMeshRenderer.SetBlendShapeWeight(0, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(21, 100);
                skinnedMeshRenderer.SetBlendShapeWeight(14, 100);
                break;
            default:
                //other
                RisetHyojyo();
                break;
        }
    }

    private void RisetHyojyo()
    {
        //Debug.Log(intBlendCount);
        for(int i=0;i<intBlendCount;i++)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(i, 0);
        }
    }
}
