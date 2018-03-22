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
    public interface IPastResource {}

    /* However, most of the exams would be described by at least the following paramters:
     * 
     * 1) Course it belongs to:
     *      Every exam must be related to a certain subject and more specifically a course in that subject.
     *      
     * 2) Exam Session:
     *      Usually a course is repetitive, at least to have a library of past exams,
     *      and the course and its exam are held once or multiple times a year at a certain intervals or "sessions".
     *      However, the description or timing of an Exam Session may vary from enviroment to another.
     *      Examples:
     *          CIE: Only "Summer (May/June)" and "Winter (Oct/Nov)" and they take place once every year.
     *          GUC: There is an exam session for each semester of 4, e.g. "Spring 2018",
     *              but there is also a schedule for "Second Chance" that follows the standard "First Chance" exams.
     *          Another enviroment could define a session by Year & Month, and another could also use the Day,
     *              that's why it is flexible.
     *              
     *  That's why this interface was made; provide an easier starting point to think about an Exam.
     */
    public interface IPastResource<TCourseLevel, TExamSession> : IPastResource where TExamSession : IExamSession
    {

        Course<TCourseLevel> Course { get; }

        TExamSession ExamSession { get; }

    }
}