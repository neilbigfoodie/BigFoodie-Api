namespace BigFoodie.Model.StoredProceedureReturnClasses
{
    public class UpUserregGetPwdQuestionReturnModel
    {
        public class ResultSetModel1
        {
            public System.String pwdquestion { get; set; }
            public System.String pwdanswer { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

        public class ResultSetModel2
        {
            public System.String pwdquestion { get; set; }
            public System.String pwdanswer { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

    }
}