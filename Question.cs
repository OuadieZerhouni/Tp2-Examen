/***********************************************************************
 * Module:  Examen.cs
 * Author:  Wadie
 * Purpose: Definition of the Class Examen
 ***********************************************************************/

using System;

public abstract class Question
{
   public void RepondreQuestion()
   {
      // TODO: implement
   }

   private int IdExamen;
   private String QuestionType;
   private String EnnonceQuestion;
   private int NumQuestion;
   
    public Question(int IdExamen , String EnnonceQuestion, int NumQuestion)
    {
        this.IdExamen = IdExamen;
        this.EnnonceQuestion = EnnonceQuestion;
        this.NumQuestion = NumQuestion;
    }

    public static void SetIdExamen(int Id)
    {
        this.IdExamen = Id;
    }
    public static int GetIdExamen()
    {
        return this.IdExamen;
    }
    public static void SetEcconceQuestion(String Ennonce)
    { thos.EnnonceQuestion = Ennonce;
    }
    public static String GetEcconceQuestion()
    {
        return this.EnnonceQuestion;
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