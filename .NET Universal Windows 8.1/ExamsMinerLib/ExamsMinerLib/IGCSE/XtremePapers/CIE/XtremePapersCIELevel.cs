namespace ExamsMinerLib.IGCSE.XtremePapers.CIE
{
    public struct XtremePapersCIELevel : ILevel
    {

        public string Name { get; }

        public XtremePapersCIELevel(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        public static readonly XtremePapersCIELevel OLevel = new XtremePapersCIELevel("Cambridge IGCSE");

        public static readonly XtremePapersCIELevel ALevel = new XtremePapersCIELevel("Cambridge International A and AS Level");

    }
}