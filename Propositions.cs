namespace Tp2_Examen
{
    public class Propositions
    {
         private int id_Q;
        private String P_text;
        private int P_num;
        public Proposition(int id,int id_Q, String text, int num)
        {
            id_Q = id;
            P_text = text;
            P_num = num;
        }
    }
}