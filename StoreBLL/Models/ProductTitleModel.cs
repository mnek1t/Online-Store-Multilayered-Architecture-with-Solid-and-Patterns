using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class ProductTitleModel : AbstractModel
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public ProductTitleModel(int id, string title, int categoryId) : base(id)
        {
            this.Id = id;
            this.Title = title;
            this.CategoryId = categoryId;
        }
        public override string ToString()
        {
            return $"Id:{Id} {Title} {CategoryId}";
        }
    }
}
