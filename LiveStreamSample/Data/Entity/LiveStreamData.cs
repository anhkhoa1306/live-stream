using System;

namespace LiveStreamSample.Data.Entity
{
    public class LiveStreamData
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsEnabled { get; set; }
        public Guid IdentityUserId { get; set; }
    }
}
