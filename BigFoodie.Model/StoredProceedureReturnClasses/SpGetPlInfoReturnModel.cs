namespace BigFoodie.Model.StoredProceedureReturnClasses
{
    public class SpGetPlInfoReturnModel
    {
        public class ResultSetModel1
        {
            public System.Int32 basicmenuid { get; set; }
            public System.Int32 shopid { get; set; }
            public System.String menutype1 { get; set; }
            public System.String menutype2 { get; set; }
            public System.String mname { get; set; }
            public System.String mname2 { get; set; }
            public System.Decimal? price1 { get; set; }
            public System.Decimal? price2 { get; set; }
            public System.String menudesc { get; set; }
            public System.String menudesc2 { get; set; }
            public System.String menucode { get; set; }
            public System.String flag { get; set; }
            public System.String menu001 { get; set; }
            public System.Decimal? indexnum { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

        public class ResultSetModel2
        {
            public System.Int32 basicmenuid { get; set; }
            public System.Int32 shopid { get; set; }
            public System.String menutype1 { get; set; }
            public System.String menutype2 { get; set; }
            public System.String mname { get; set; }
            public System.String mname2 { get; set; }
            public System.Decimal? price1 { get; set; }
            public System.Decimal? price2 { get; set; }
            public System.String menudesc { get; set; }
            public System.String menudesc2 { get; set; }
            public System.String menucode { get; set; }
            public System.String flag { get; set; }
            public System.String menu001 { get; set; }
            public System.Decimal? indexnum { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

    }
}