/***********************************************************************
 * Module:  Examen.cs
 * Author:  Wadie
 * Purpose: Definition of the Class Examen
 ***********************************************************************/

using System;
using  Question;
using ReponseOuverte;


public class QuestionOuverte:Question
{
   private ReponseOuverte Reponse ;
   private ReponseOuverte ReponseVrais ;

    public QuestionOuverte(ReponseOuverte ReponseVrais):base()
    {
        SetReponseVrais(ReponseVrais);

    }
    public static void SetReponseVrais(ReponseOuverte ReponseVrais)
    {
        this.ReponseVrais = ReponseVrais;
    }
    public static ReponseOuverte GetReponseVrais()
    {
        return this.ReponseVrais ;
    }
    public static void SetReponse(ReponseOuverte Reponse)
    {
        this.Reponse = Reponse;
    }
    public static ReponseOuverte GetReponse()
    {
        return this.Reponse;
    }


    public static void Repondre(ReponseOuverte Reponse)
    {
        SetReponse(Reponse);
    }

}