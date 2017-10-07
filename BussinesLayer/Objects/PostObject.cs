using System;

namespace BussinesLayer.Objects
{
    public class PostObject
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string Text { get; set; }
        public DateTime DataTime { get; set; }
    }
}