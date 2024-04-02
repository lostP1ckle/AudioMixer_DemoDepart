using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;
    void Start()
    {
        //audioMixer.SetFloat("VolumeMusique",-30f);
    }
    public void AdusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique",ConvertToLogarithmique(volume));
    }
    public void AdusteVolumeFX(float volume){
        audioMixer.SetFloat("VolumeFX",ConvertToLogarithmique(volume));
    }
    private float ConvertToLogarithmique(float volume){
        return Mathf.Log10(volume)*20;
    }
}