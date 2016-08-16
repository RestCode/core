namespace RestCode.Core.Infrastructure
{
    using Models;
    public interface IMetadataProvider
    {
        Metadata GetMetadata(string baseUrl = "");
    }
}
