namespace LiveStreamSample.Models
{
    public class PropertyEditDto
    {
        public int Id { get; set; }
        public string LiveStreamUrl { get; set; }
        public bool IsEnabled { get; set; } = false;
    }
}
