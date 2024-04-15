using UnityEngine;

public class ChemistryReaction : MonoBehaviour
{
    public Color targetColor = Color.magenta; 
    public ParticleSystem smellEffect;  
    private bool isChangingColor = false;  
    private Renderer renderer;
    public float colorChangeSpeed = 1.0f;  

    void Start()
    {
        renderer = GetComponent<Renderer>();  
    }

    public void Interact()
    {
        if (!isChangingColor) 
        {
            isChangingColor = true;
            if (smellEffect != null)
            {
                EmitSmell();  
            }
        }
    }

    void Update()
    {
        if (isChangingColor)
        {
          
            renderer.material.color = Color.Lerp(renderer.material.color, targetColor, colorChangeSpeed * Time.deltaTime);

            if (ColorDifference(renderer.material.color, targetColor) < 0.01f)
            {
                renderer.material.color = targetColor; 
                isChangingColor = false;  
            }
        }
    }

    
    private float ColorDifference(Color a, Color b)
    {
        return Mathf.Abs(a.r - b.r) + Mathf.Abs(a.g - b.g) + Mathf.Abs(a.b - b.b);
    }


    
    private void EmitSmell()
    {
        if (!smellEffect.isPlaying)
        {
            smellEffect.Play();
        }
    }
}
