namespace BigFoodie.Model
{
    public class Sysdiagram
    {
        public string Name { get; set; } // name
        public int PrincipalId { get; set; } // principal_id
        public int DiagramId { get; set; } // diagram_id (Primary key)
        public int? Version { get; set; } // version
        public byte[] Definition { get; set; } // definition
    }
}