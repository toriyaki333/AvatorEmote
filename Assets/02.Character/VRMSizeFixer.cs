using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMSizeFixer : MonoBehaviour
{

    public float minSize;//������̍ŏ��T�C�Y
    public float maxSize;//������̍ő�T�C�Y
    public GameObject VRMModel;//�Ώۂ̃��f��
    public GameObject XROriginSetUpObj;
    private Transform transSelf;
    private Animator anime;
    private Transform transHead;
    private Transform transFoot;
    private float defaultHeight;
    // Use this for initialization
    void Start()
    {
        anime = VRMModel.GetComponent<Animator>();
        transSelf = XROriginSetUpObj.GetComponent<Transform>();
        transHead = anime.GetBoneTransform(HumanBodyBones.Head);
        transFoot = anime.GetBoneTransform(HumanBodyBones.RightFoot);
        defaultHeight = transHead.position.y - transFoot.position.y;
        //Debug.Log(defaultHeight);
        if (defaultHeight < minSize)
        {
            float multiply = minSize / defaultHeight;
            transSelf.localScale = new Vector3(multiply, multiply, multiply);
        }
        else if (defaultHeight > maxSize)
        {
            float multiply = maxSize / defaultHeight;
            transSelf.localScale = new Vector3(multiply, multiply, multiply);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
