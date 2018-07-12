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