using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Cinema.DataProcessor.ImportDto
{
    [XmlType("Projection")]
    public class ProjectionInputModel
    {
        
        
            [Required]
            [XmlElement("MovieId")]
            public int MovieId { get; set; }


            [Required]
            [XmlElement("DateTime")]
            public string DateTime { get; set; }
        
    }
}