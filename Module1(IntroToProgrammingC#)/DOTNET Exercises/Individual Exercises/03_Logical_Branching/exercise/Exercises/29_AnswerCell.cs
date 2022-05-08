﻿namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Your cell phone rings. Return true if you should answer it. Normally you answer, except in the morning
         you only answer if it is your mom calling. In all cases, if you are asleep, you do not answer.
         AnswerCell(false, false, false) → true
         AnswerCell(false, false, true) → false
         AnswerCell(true, false, false) → false
         */
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            }
            else if (isMorning && isMom)
            {
                return true;
            }
            else if (isMorning)
            {
                return false;
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
