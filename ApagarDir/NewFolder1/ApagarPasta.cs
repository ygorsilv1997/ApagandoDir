using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ApagarDir.NewFolder1
{
    class ApagarPasta
    {
        public void ApagarDir(List<String> Sol, String caminho )
        {
            for (int i = 0;i<Sol.Count; i++)
            {
                String montarCaminho = caminho+@"\"+Sol[i];
                if (Directory.Exists(@montarCaminho))
                {
                    Directory.Delete(@montarCaminho);
                }
            }
        }
    }
}
