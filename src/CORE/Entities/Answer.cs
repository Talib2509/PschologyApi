using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsychologyApi.Core.Entities.Common;

namespace PsychologyApi.Core.Entities
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; } 
        public int Score { get; set; } 
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}