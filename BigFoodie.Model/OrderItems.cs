using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigFoodie.Model
{
        public class OrderItems
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2212:DoNotCallOverridableMethodsInConstructors")]
            public OrderItems()
            {
                Items = new HashSet<Item>();
            }

            public int Id { get; set; }

            public string Name { get; set; }

            //many to many
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Item> Items { get; set; }

            [NotMapped]
            public IList<string> Names { get; set; }

        
    }
}
