using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAsync
{
    public class Exemplo
    {
        //Método de retorno
        bool TaskTResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        //Método com retorno void
        void TaskVoid()
        {
            Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa longa executada");
        }

        public void TaskLongaDuracao()
        {
            bool isAnoBissexto = TaskTResult();
            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um ano Bissexto");
            TaskVoid();
        }
    }
}
