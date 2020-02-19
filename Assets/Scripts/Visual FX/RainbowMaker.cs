using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class RainbowMaker : MonoBehaviour
{
    public bool MakeRainbow = false;

    private Volume volume;
    private ColorAdjustments ca;

    void Awake()
    {
        this.volume = this.gameObject.GetComponent<Volume>();
        this.volume.profile.TryGet<ColorAdjustments>(out this.ca);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.MakeRainbow == true)
        {
            this.ca.hueShift.value += 1;
            if(this.ca.hueShift.value >= 180)
            {
                this.ca.hueShift.value = -180;
            }
        }
    }
}
