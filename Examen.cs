/***********************************************************************
 * Module:  Examen.cs
 * Author:  Wadie
 * Purpose: Definition of the Class Examen
 ***********************************************************************/

using System;


public class Examen
{
   public Question question;

   private int Duree;
   private int IdExamen;

    public static void SetDuree(int Duree)
    {
        this.Duree = Duree;
    }
    public static int GetDuree()
    {
        return this.Duree;
    }
    public static void SetIdExamen(int Id)
    {
        this.IdExamen = Id;
    }
    public static int GetIdExamen()
    {
        return this.IdExamen;
    }

    

}