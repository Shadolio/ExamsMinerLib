using ExamsMinerLib.Model;

namespace ExamsMinerLib.IGCSE
{
    public struct ExamSession : IExamSession
    {

        public int Year { get; }

        public SessionEnum Session { get; }

        public ExamSession(SessionEnum summerOrWinter, int year)
        {
            Session = summerOrWinter;
            Year = year;
        }

    }
}