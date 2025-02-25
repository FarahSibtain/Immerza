#ifndef WATERLIGHTING_INCLUDED
#define WATERLIGHTING_INCLUDED

float LightingSpecular(float3 L, float3 N, float3 V, float smoothness)
{
    float3 H = SafeNormalize(float3(L) + float3(V));
    float NdotH = saturate(dot(N, H));
    return pow(NdotH, smoothness);
}

void DirLighting_float(float3 normalWS, float3 positionWS, float3 viewDirWS, float smoothness, out float specular)
{
    specular = 0.0;

    #ifndef SHADERGRAPH_PREVIEW
    smoothness = exp2(10 * smoothness + 1);

    normalWS = normalize(normalWS);
    viewDirWS = SafeNormalize(viewDirWS);

    Light mainLight = GetMainLight(TransformWorldToShadowCoord(positionWS));
    specular = LightingSpecular(mainLight.direction, normalWS, viewDirWS, smoothness);
    #endif
}

#endif