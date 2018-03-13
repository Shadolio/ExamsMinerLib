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
    /// <summary>
    /// Represents a subject course that an exam is typically linked to.
    /// </summary>
    /// <typeparam name="TLevel">Specifies the structure that is used to select the level of the course. Can be a primitive, struct, class or interface.</typeparam>
    public struct Course<TLevel>
    {

        /// <summary>
        /// Gets the Course Code. Usually the one used for identification, e.g. "CSEN202" (for Degree courses) or "9602" (for IGCSE).
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Gets the course's subject. Usually more friendly descriptor than <see cref="Code"/>, e.g. "Accounting".
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Show the level of this Course. The way levels are modelled may differ from one enviroment to another.
        /// </summary>
        /// <remarks>
        /// Helpful when a subject has courses of different levels, e.g. Accounting OL vs. AS vs. AL,
        /// or to just describe it for knowledge, that might be used for search later.
        /// </remarks>
        public TLevel Level { get; private set; }

        /// <summary>
        /// Describe a new Course that can be used to describe an Exam.
        /// </summary>
        public Course(string code, string name, TLevel level)
        {
            Code = code;
            Name = name;
            Level = level;
        }

    }
}