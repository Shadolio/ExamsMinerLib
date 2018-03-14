using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsMinerLib.Model
{
    public abstract class MiningGround<TDoc> where TDoc : IExam
    {

        /* A MiningGround contains the logic that decides the predicated URL of an exam in a specific pool.
         * 
         * Example: Although the definition of an Exam is the same for IGCSE, particularly for CIE,
         * a website like "XtremePapers" can have a different way to name exam files and organise their directory
         * than another more recent website that started providing past papers on their website,
         * and possibly different from the way Cambridge could use if they provided their exams on the Internet,
         * and they are all (although could be not) totally different from the MiningGround in my faculty/department.
         * 
         * Therefore, developers will probably inherit this class to make an application to get exams
         * for a certain community, or use a MiningGround already implemented like the one I made for XtremePapers/CIE.
         * 
         * Moreover, the class takes a <TypeParam> for the Exam definition it deals with.
         * This helps us a lot to build a MiningGround that deals with a specific model/type of Exams.
         * 
         * For example, if we have a class named 'IGExam' that implements 'IExam,'
         * and has more specific attributes like "Paper" and "Variant" that contribute to the predicted URL,
         * specifying 'IGExam' as the type parameter to one or more MiningGrounds will save us from type casting
         * and its checks and errors, which would have otherwise be necessary if we just takes an 'IExam'.
         * 
         * However, developers are free to make a MiningGround as specific or general-purpose as they want.
         * A general-purpose MiningGround is one that takes a broad definition and decides in its logic what to do with it,
         * e.g. taking the 'IExam' interface itself, or a class that implements it but does not add much to it yet.
         */

    }
}