//using CSR.IO;

namespace CSR.System
{
    [Flags]
    public enum PostType
    {
        UNKNOWN = 0,
        Member = 1,
        Link = 2,
        Media = 4,
        System = 8,
        Forward = 16,
        Textual = 32
    }
}
