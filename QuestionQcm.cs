/***********************************************************************
 * Module:  Examen.cs
 * Author:  Wadie
 * Purpose: Definition of the Class Examen
 ***********************************************************************/

using System;
using  Question;

public class QuestionQcm : Question
{
   private string[] Propositions;
   private ReponseQcm Reponse;

    public static void SetReponse(ReponseQcm Reponse)
    {
        this.Reponse = Reponse;
    }
    public static ReponseOuverte GetReponseVrais()
    {
        return this.ReponseVrais;
    }
}