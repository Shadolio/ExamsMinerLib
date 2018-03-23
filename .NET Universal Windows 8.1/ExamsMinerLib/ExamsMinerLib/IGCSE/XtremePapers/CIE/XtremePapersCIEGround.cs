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

        private const string BASE_URL = "http://papers.xtremepapers.com/CIE/";

        public override Uri PredictResourceUri(PastPaperResource past_paper)
        {
            string relativeUri = "";

            // Level path
            relativeUri += past_paper.Course.Level.Name + '/';

            // Subject path
            relativeUri += string.Format("{0} ({1})", past_paper.Course.Name, past_paper.Course.Code) + '/';

            // Past paper (question paper)
            relativeUri += string.Format("{0}_{1}{2}_{3}_{4}{5}.pdf",
                past_paper.Course.Code,                                                     // 0: Course Code
                past_paper.ExamSession.Session.ToString().ToLower().Substring(0, 1),        // 1: s = "Summer", w = "Winter"
                new DateTime(past_paper.ExamSession.Year, 1, 1).ToString("yy"),             // 2: Year in "yy" format
                past_paper.ResourceType == ResourceTypeEnum.QuestionPaper ? "qp" : "ms",    // 3: Paper Type
                past_paper.Paper,                                                           // 4: Paper
                past_paper.Variant);                                                        // 5: Variant

            return new Uri(new Uri(BASE_URL, UriKind.Absolute), relativeUri);
        }

        public override string ToString() => "XtremePapers/CIE";

    }
}