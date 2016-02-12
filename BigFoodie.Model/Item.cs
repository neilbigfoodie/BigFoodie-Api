
using System.Collections.Generic;

namespace BigFoodie.Model
{
    public class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2212:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        public string DEscription { get; set; }
        
        //many to many
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual  ICollection<Order> Orders { get; set; } 

    }
}
