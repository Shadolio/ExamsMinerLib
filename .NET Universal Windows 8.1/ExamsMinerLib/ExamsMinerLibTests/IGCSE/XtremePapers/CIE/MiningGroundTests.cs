using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using ExamsMinerLib.Model;
using ExamsMinerLib.IGCSE;
using ExamsMinerLib.IGCSE.XtremePapers.CIE;

namespace ExamsMinerLibTests.IGCSE.XtremePapers.CIE
{
    [TestClass]
    public class MiningGroundTests
    {

        [TestMethod]
        public void PredictExamUri_qp_OLevel_Variants()
        {

            // 0452_s12_qp_11.pdf (Accounting)
            PastPaperResource testResource = new PastPaperResource()
            {
                Course = new Course<XtremePapersCIELevel>("0452", "Accounting", XtremePapersCIELevel.OLevel),
                ExamSession = new ExamSession(SessionEnum.Summer, 2012),
                Paper = "1",
                Variant = "1"
            };

            //
            Uri expectedUri = new Uri(
                "http://papers.xtremepapers.com/CIE/Cambridge%20IGCSE/Accounting%20(0452)/0452_s12_qp_11.pdf",
                UriKind.Absolute);

            //
            XtremePapersCIEGround ground = new XtremePapersCIEGround();
            Uri predictedUri = ground.PredictResourceUri(testResource);

            // Assert
            Assert.AreEqual(expectedUri, predictedUri);

        }

    }
}