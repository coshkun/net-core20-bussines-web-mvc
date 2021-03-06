using System;

namespace fullybusiness.Domain.Slider
{
    public class Slider: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TargetURL { get; set; }
        public string ImageURL { get; set; }
        public int OrderNumber { get; set; }
    }
}