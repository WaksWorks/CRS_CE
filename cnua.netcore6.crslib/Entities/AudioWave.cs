
namespace CSR.Entities
{
    /// <summary>
    /// info for sound ops
    /// </summary>
    public partial class AudioWave
    {
        public int AudioWaveId { get; set; }
        public virtual Guid? AudioWaveGuid { get; set; }
        public virtual string? AudioWaveConfig { get; set; }
        public FileStream? WaveStream { get; set; }
        public VoiceInfo? Voiceinfo { get; set; } 
    }
}