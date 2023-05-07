namespace Bridge.Platforms
{
    public interface IPlatform
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}
