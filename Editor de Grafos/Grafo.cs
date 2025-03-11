using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace Editor_de_Grafos
{
    public class Grafo : GrafoBase, iGrafo
    {
        public bool[] visitado;

        public void AGM(int v)
        {

        }

        public void CaminhoMinimo(int i, int j)
        {

        }

        public void CompletarGrafo()
        {

        }

        public bool IsEuleriano()
        {
            for (int i = 0; i < getN(); i++)
            {
                if (grau(i) % 2 != 0)
                {
                    return false;
                }
                else if(grau(i) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsUnicursal()
        {
            int aux = 0;

            for (int i = 0; i < getN(); i++)
            {

                if (grau(i) % 2 != 0)
                {
                    aux++;
                }

            }

            if (aux != 2)
            {
                return false;
            }

            return true;
        }

        public void Largura(int v)
        {

        }

        public void NumeroCromatico()
        {
        }

        public String ParesOrdenados()
        {
            // getAresta(vi, vj) == null => aresta não existe
            // getVertice(v) => object "Vertice"
            //getVertice(0).setCor(Color.Red);
            //getVertice(0).setRotulo("BH");
            //getAresta(0, 1).setPeso(5);
            return "E={...}";
        }
        public void Profundidade(int v)
        {

        }
    }
}
