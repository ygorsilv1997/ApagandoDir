using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ApagarDir.DAO;
using ApagarDir.NewFolder1;

namespace ApagarDir
{
    public class Class1
    {
        public void Teste()
        {
            List<String> solicitacoes = new List<String>();
            String dirAnexo = "";
            GetSolicitacoes getSol = new GetSolicitacoes();

            solicitacoes= getSol.GetSol();
            dirAnexo = getSol.GetDirAnexo();

            ApagarPasta apagar = new ApagarPasta();
            apagar.ApagarDir(solicitacoes,dirAnexo);


        }
    } 
}
