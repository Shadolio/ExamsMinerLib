/** Copyright 2018 Shadi Barghash
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 *     
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using ExamsMinerLib.Model;

namespace ExamsMinerLib.IGCSE.XtremePapers.CIE
{
    /// <summary>
    /// Ground for mining IGCSE Cambrdige exams from "XtremePapers" website.
    /// </summary>
    public class XtremePapersCIEGround : MiningGround<PastPaperResource>
    {

        private const string BASE_URL = "http://papers.xtremepapers.com/CIE";

        public override Uri PredictResourceUri(PastPaperResource past_paper)
        {
            string relativeUri = "/";

            // Level path
            relativeUri += past_paper.Course.Level.Name + '/';

            // Subject path
            relativeUri += string.Format("{0} ({1})", past_paper.Course.Name, past_paper.Course.Code) + '/';

            // Exam Session: "s" -> Summer, "w" -> Winter
            SessionEnum session = past_paper.ExamSession.Session;
            string sessionCode =
                session == SessionEnum.Summer ? "s" :
                session == SessionEnum.Winter ? "w" :
                session.ToString().Substring(0, 1).ToLower();

            // Year code: "yy" format
            string yearCode =
                new DateTime(past_paper.ExamSession.Year, 1, 1).ToString("yy");

            // Resource Type Code
            ResourceTypeEnum resType = past_paper.ResourceType;
            string resTypeCode =
                resType == ResourceTypeEnum.QuestionPaper ? "qp" :
                resType == ResourceTypeEnum.MarkingScheme ? "ms" :
                resType.ToString();

            // Past paper (question paper)
            relativeUri += string.Format("{0}_{1}{2}_{3}_{4}{5}.pdf",
                past_paper.Course.Code,                                 // 0: Course Code
                sessionCode,                                            // 1: Session Code (e.g. 's', 'w')
                yearCode,                                               // 2: Year Code ("yy" format)
                resTypeCode,                                            // 3: Paper Type (e.g. "qp", "ms")
                past_paper.Paper,                                       // 4: Paper
                past_paper.Variant);                                    // 5: Variant

            return new Uri(new Uri(BASE_URL, UriKind.Absolute), relativeUri);
        }

        public override string ToString() => "XtremePapers/CIE";

    }
}