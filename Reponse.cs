/***********************************************************************
 * Module:  Examen.cs
 * Author:  Wadie
 * Purpose: Definition of the Class Examen
 ***********************************************************************/

using System;

namespace Reponse
{

    public abstract class Reponse
    {
        private int NumQuestion;
        private int IdExamen;

        public Reponse(int NumQuestion, int IdExamen)
        {
            SetNumQuestion(NumQuestion);
            SetIdExamen(IdExamen);
        }
        public static void SetIdExamen(int Id)
        {
            this.IdExamen = Id;
        }
        public static int GetIdExamen()
        {
            return this.IdExamen;
        }
        public static void SetNumQuestion(int NumQuestion)
        {
            this.NumQuestion = NumQuestion;
        }
        public static int GetNumQuestion()
        {
            return this.NumQuestion;
        }
    }
}