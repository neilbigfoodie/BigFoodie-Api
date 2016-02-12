namespace BigFoodie.Model.StoredProceedureReturnClasses
{
    public class SpGetMenuInfosReturnModel
    {
        public class ResultSetModel1
        {
            public System.Int32 mid { get; set; }
            public System.Int32 shopid { get; set; }
            public System.String menuCat { get; set; }
            public System.String menuName { get; set; }
            public System.String menuName2 { get; set; }
            public System.String menuDesc { get; set; }
            public System.String menuDesc2 { get; set; }
            public System.Decimal? price1 { get; set; }
            public System.Decimal? price2 { get; set; }
            public System.Decimal? star { get; set; }
            public System.String menutype { get; set; }
            public System.String menulogo { get; set; }
            public System.String discountway { get; set; }
            public System.String menucode { get; set; }
            public System.String servicePeriod { get; set; }
            public System.String displayweekday { get; set; }
            public System.String hasSideOrder { get; set; }
            public System.String hasPL { get; set; }
            public System.String standardpl { get; set; }
            public System.DateTime? CreateDT { get; set; }
            public System.DateTime? UpdateDT { get; set; }
            public System.String flag { get; set; }
            public System.Decimal? indexnum { get; set; }
            public System.Int32? mealamt { get; set; }
            public System.String menuoptioncat { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

        public class ResultSetModel2
        {
            public System.Int32 mid { get; set; }
            public System.Int32 shopid { get; set; }
            public System.String menuCat { get; set; }
            public System.String menuName { get; set; }
            public System.String menuName2 { get; set; }
            public System.String menuDesc { get; set; }
            public System.String menuDesc2 { get; set; }
            public System.Decimal? price1 { get; set; }
            public System.Decimal? price2 { get; set; }
            public System.Decimal? star { get; set; }
            public System.String menutype { get; set; }
            public System.String menulogo { get; set; }
            public System.String discountway { get; set; }
            public System.String menucode { get; set; }
            public System.String servicePeriod { get; set; }
            public System.String displayweekday { get; set; }
            public System.String hasSideOrder { get; set; }
            public System.String hasPL { get; set; }
            public System.String standardpl { get; set; }
            public System.DateTime? CreateDT { get; set; }
            public System.DateTime? UpdateDT { get; set; }
            public System.String flag { get; set; }
            public System.Decimal? indexnum { get; set; }
            public System.Int32? mealamt { get; set; }
            public System.String menuoptioncat { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

    }
}