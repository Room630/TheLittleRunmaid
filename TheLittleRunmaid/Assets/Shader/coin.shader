Shader "Custom/coin"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        // _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 1.0 
        _Smoothness ("Smoothness", Range(0,1)) = 0.5 
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard

        sampler2D _MainTex;
        float _Metallic;
        float _Smoothness;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) ;
            o.Albedo = c.rgb;
            // Metallic and smoothness come from slider variables
            o.Metallic = _Metallic;
            o.Smoothness = _Smoothness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
