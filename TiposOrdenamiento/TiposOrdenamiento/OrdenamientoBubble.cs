
namespace TiposOrdenamiento
{
    public class OrdenamientoBubble
    {
        public int[] OrdenarBubbleInt(int[] entrada)
        {
            for (int a = 0; a < entrada.Length; a++)
            {
                for (int b = 0; b < entrada.Length - 1; b++)
                {
                    if (entrada[b] > entrada[b + 1])
                    {
                        int tmp = entrada[b];
                        entrada[b] = entrada[b + 1];
                        entrada[b + 1] = tmp;
                    }
                }
            }
            return entrada;
        }

        public double[] OrdenarBubbleDouble(double[] entrada)
        {
            for (int a = 0; a < entrada.Length; a++)
            {
                for (int b = 0; b < entrada.Length - 1; b++)
                {
                    if (entrada[b] > entrada[b + 1])
                    {
                        double tmp = entrada[b];
                        entrada[b] = entrada[b + 1];
                        entrada[b + 1] = tmp;
                    }
                }
            }
            return entrada;
        }
    }
}
