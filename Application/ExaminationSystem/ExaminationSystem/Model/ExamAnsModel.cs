using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class ExamAnsModel
    {
        public int questionID {  get; set; }
        public string questionText {  get; set; }
        public string answerText { get; set; }
        public string modelAnsText{ get; set; }
    }
}
