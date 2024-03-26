

namespace ExaminationSystem.Models
{
    public class ExamAnsModel
    {
        
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string StudentAnswer { get; set; }
        public string ModelAnswer { get; set; }
    }
}
