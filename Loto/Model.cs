using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Windows.Storage;
using System.IO;
using Windows.UI.Popups;

namespace App1
{
    class Model
    {
        public Model()
        {
            CriarBanco();
        }

        private SQLiteConnection SqlConexao;

        private void CriarBanco()
        {
            SqlConexao = new SQLiteConnection("Arquivo.db");
            
            string SqlCriarTabela = 
                @"CREATE TABLE IF NOT EXISTS JOGOS([ID] VARCHAR(40) NOT NULL,
                [NUMERO_JOGO] VARCHAR(40) NOT NULL,
                CONSTRAINT PK_JOGO PRIMARY KEY(ID))";

            ISQLiteStatement QUERY = SqlConexao.Prepare(SqlCriarTabela);
            QUERY.Step();                     
        }

        public Boolean ValidarJogo(string ID)
        {
            string Select = @"SELECT * FROM JOGOS WHERE ID = '"+ ID + "'";
            ISQLiteStatement Query = SqlConexao.Prepare(Select);

            return Query.Step() == SQLiteResult.ROW;
        }

        public string ObterJogo(string ID)
        {
            string Select = @"SELECT [NUMERO_JOGO] FROM JOGOS WHERE [ID] = '"+ ID + "'";
            ISQLiteStatement Query = SqlConexao.Prepare(Select);

            if (Query.Step() == SQLiteResult.ROW)
            {
                return Convert.ToString(Query["NUMERO_JOGO"]);
            }
            else
            {
                return "";
            }
        }

        public async void SalvarJogo(string ID, string Jogo)
        {
            string SqlQuery;
            if (ValidarJogo(ID))
            {
                SqlQuery = @"UPDATE JOGOS SET NUMERO_JOGO = '" + Jogo + "' WHERE ID = '" + ID + "'";
            }
            else
            {
                SqlQuery = @"INSERT INTO JOGOS VALUES('" + ID + "','" + Jogo + "')";
            }

            SqlConexao.Prepare(SqlQuery).Step();
            var dialog = new MessageDialog("");
            dialog.Title = "Jogo Salvo!";
            dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
            var res = await dialog.ShowAsync();
        }
    }
}
