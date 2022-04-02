namespace FAQList.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionMSG { get; set; }
        public string TopicType { get; set; }
        public int TopicID { get; set; }
        public string CategoryType { get; set; }
        public int CategoryID { get; set; }


    }
}
