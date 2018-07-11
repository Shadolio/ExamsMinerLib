namespace ExamsMinerLib.IGCSE.XtremePapers.CIE
{
    public class PastPaperResource : PastPaperResource<XtremePapersCIELevel, ExamSession>
    {

        // Question Paper, Marking Scheme, etc...
        public ResourceTypeEnum ResourceType { get; set; } = ResourceTypeEnum.QuestionPaper;

    }
}