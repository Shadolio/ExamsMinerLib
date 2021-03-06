﻿/** Copyright 2018 Shadi Barghash
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

using ExamsMinerLib.Model;

namespace ExamsMinerLib.IGCSE.XtremePapers.CIE
{
    
    public class PastPaperResource : PastPaperResource<XtremePapersCIELevel, ExamSession>
    {

        // Question Paper, Marking Scheme, etc...
        public ResourceTypeDescriptor ResourceType { get; set; }

        public PastPaperResource(Course<XtremePapersCIELevel> course,
            ExamSession session, ResourceTypeDescriptor resource_type,
            string paper, string variant)
        {
            Course = course;
            ExamSession = session;
            ResourceType = resource_type;
            Paper = paper;
            Variant = variant;
        }

    }
}