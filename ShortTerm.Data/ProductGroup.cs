using System.ComponentModel.DataAnnotations.Schema;

namespace ShortTerm.Data
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        [ForeignKey("SchemeId")]
        public Scheme Scheme { get; set; }
        public int SchemeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
