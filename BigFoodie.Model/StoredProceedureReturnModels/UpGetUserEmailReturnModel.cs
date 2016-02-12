namespace BigFoodie.Model.StoredProceedureReturnModels
{
    public class UpGetUserEmailReturnModel
    {
        public class ResultSetModel1
        {
            public System.String uname { get; set; }
            public System.String email { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

        public class ResultSetModel2
        {
            public System.String uname { get; set; }
            public System.String email { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

    }
}