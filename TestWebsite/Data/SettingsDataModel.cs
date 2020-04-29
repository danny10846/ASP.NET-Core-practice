using System.ComponentModel.DataAnnotations;

namespace TestWebsite.Data {

    /// <summary>
    /// Our Settings database table representational model. Each column represents a column within our DB
    /// </summary>
    public class SettingsDataModel {
        
        /// <summary>
        /// Unique Id for this entry, Entity framework detects this as the primary key by name. 
        /// We can also tag it with an attribute to make sure it's explicitly stated 
        /// </summary>
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(256)]

        public string Name { get; set; }
        [MaxLength(2048)]
        [Required]
        public string Value { get; set; }
    }
}
