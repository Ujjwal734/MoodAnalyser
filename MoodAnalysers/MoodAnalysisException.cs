using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysers
{
    public class MoodAnalysisException:Exception
    { 
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
        }
        private readonly ExceptionType type;
        public MoodAnalysisException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
