namespace AspxParser
{
    public class AspxParseError
    {
        public Location Location { get; }

        public string Message { get; }

        public AspxParseError(Location location, string message)
        {
            Location = location;
            Message = message;
        }
    }
}
