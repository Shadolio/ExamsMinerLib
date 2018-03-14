namespace ExamsMinerLib.Model
{
    /* Different enviroments can have different ways/attributes to define an Exam.
     * 
     * For example, IGCSE has "paper and variant," while university does not have the paper notion,
     * and might not use the variant notion the same way. Moreover it has "First Chance" and "Second Chance".
     * 
     * Therefore, developers are free to define an Exam as a class or struct or a hierarchy that at the end implements
     * this interface so a MiningGround can recognise it.
     */
    public interface IExam
    {

    }
}