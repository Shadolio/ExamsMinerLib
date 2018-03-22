namespace ExamsMinerLib.IGCSE.XtremePapers.CIE
{
    public class PastPaperResource : PastPaperResource<XtremePapersCIELevel, ExamSession>
    {

        public ResourceTypeEnum ResourceType { get; } = ResourceTypeEnum.QuestionPaper; // Question Paper, Marking Scheme, etc...

    }
}