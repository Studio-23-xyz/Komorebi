using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class WindowAnim : MonoBehaviour
{
    [SerializeField]
    private Renderer _render;
    [SerializeField]
    private Range metalicity;

    [SerializeField]
    private Light _directional_light;
    [SerializeField]
    private Range intensity;

    [SerializeField]
    private Range normal_bias;

    void Start()
    {
        
        Material material = _render.materials[0];
        
        float metalic = metalicity.Start;
        DOTween.To(() => metalic, x => metalic = x, metalicity.End, .5f)
            .OnUpdate(() => {
                material.SetFloat("_Metallic", metalic);
            }).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);


        float _intensity = intensity.Start;
        DOTween.To(() => _intensity, x => _intensity = x, intensity.End, .5f)
            .OnUpdate(() => {
                _directional_light.intensity = _intensity;
            }).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);

        float _normal_bias = normal_bias.Start;
        DOTween.To(() => _normal_bias, x => _normal_bias = x,normal_bias.End, .5f)
            .OnUpdate(() => {
                _directional_light.shadowNormalBias = _normal_bias;
            }).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);

    }

}
