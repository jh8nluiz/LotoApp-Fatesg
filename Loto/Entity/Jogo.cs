using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto.Entity
{
    public class Concurso
    {
        public string numero { get; set; }
        public string data { get; set; }
        public string cidade { get; set; }
        public string local { get; set; }
        public string valor_acumulado { get; set; }
        public List<string> dezenas { get; set; }
        public List<string> dezenas_1 { get; set; }
        public List<string> dezenas_2 { get; set; }
        public string arrecadacao_total { get; set; }
    }

    public class ProximoConcurso
    {
        public string data { get; set; }
        public string valor_estimado { get; set; }
    }

    public class Jogo
    {
        public Concurso concurso { get; set; }
        public ProximoConcurso proximo_concurso { get; set; }
        public string valor_acumulado_final_cinco { get; set; }
        public string valor_acumulado_final_zero { get; set; }
        public string mega_virada_valor_acumulado { get; set; }
        public string resultado_completo { get; set; }
        public string TipoJogo { get; set; }
        public string Resultado { get; set; }
    }
}
