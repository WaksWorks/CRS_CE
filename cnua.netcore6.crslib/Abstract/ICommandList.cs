namespace CSR.Abstract
{
    public interface ICommandList
    {
        List<Post> Posts { get; set; }

        string GetFilePath();
        void LoadCSV();
        void LoadJson();
        void LoadOriginalText();
        void SaveCSV();
        void SaveJson();
        void SaveOriginalText();
        void WriteAudioPosts();
        void WriteAudioTranscription();
    }
}