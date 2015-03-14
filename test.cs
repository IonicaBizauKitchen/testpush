namespace CodeCompressor.Parsing
{
    public interface ITextItem
    {
        TextItemType ContentType { get; }
        string GetContent();
        int BeginLineNumber { get; }
        int BeginColumnNumber { get; }
        int EndLineNumber { get; }
        int EndColumnNumber { get; }
    }
}
