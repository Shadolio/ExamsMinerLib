namespace ExamsMinerLib.IGCSE.XtremePapers.CIE
{
    public struct ResourceTypeDescriptor
    {

        /// <summary>
        /// This code shall be used to form the URL. For example, "qp" or "ms".
        /// </summary>
        public string Code { get; }

        public ResourceTypeDescriptor(string code)
        {
            Code = code;
        }

    }
}
